using System.Net.WebSockets;
using System;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Collections.Generic;
public class SocketClient
{
    private ClientWebSocket socketClient;
    private CancellationToken ct;

    public delegate void MessageHandler(int cmd, byte[] data);
    public delegate void ConnectHandler();
    public delegate void DisconnectHandler();

    public MessageHandler onData;
    public ConnectHandler onConnect;

    public DisconnectHandler onDisconnect;
    public SocketClient()
    {

    }

    public async void createSocket(string host)
    {
        try
        {
            socketClient = new ClientWebSocket();
            ct = new CancellationToken();
            Uri url = new Uri(host);
            await socketClient.ConnectAsync(url, ct);
            if (onConnect != null)
            {
                onConnect();
            }
            WaitReciveData();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public async void SendData(int cmd, byte[] data)
    {
        try
        {
            //写入数据长度和cmd号
            byte[] lenArr = BitConverter.GetBytes((Int32)data.Length);
            byte[] cmdArr = BitConverter.GetBytes((Int16)cmd);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(lenArr);
                Array.Reverse(cmdArr);
            }
            List<byte> arr = new List<byte>();

            arr.AddRange(cmdArr);
            arr.AddRange(lenArr);
            arr.AddRange(data);

            await socketClient.SendAsync(new ArraySegment<byte>(arr.ToArray()), WebSocketMessageType.Binary, true, ct);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    private void WaitReciveData()
    {
        OnLoop();
    }

    private void checkDisConnect(WebSocketReceiveResult result)
    {
        var isDisconnect = result.CloseStatus.HasValue;
        if (isDisconnect)
        {
            socketClient.Dispose();
            socketClient = null;
            if (onDisconnect != null)
            {
                onDisconnect();
            }
        }
    }

    private async void OnLoop()
    {
        //全部消息容器
        List<byte> bs = new List<byte>();
        //缓冲区
        var buffer = new byte[1024];
        //监听Socket信息
        WebSocketReceiveResult result = await socketClient.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        //是否关闭
        checkDisConnect(result);
        while (!result.CloseStatus.HasValue)
        {
            var len = result.Count;
            var tmpbytes = new byte[len];
            Array.Copy(buffer, tmpbytes, len);

            bs.AddRange(tmpbytes);

            //消息是否已接收完全
            if (result.EndOfMessage)
            {
                var arr = bs.ToArray();
                byte[] cmdArr = new byte[2];
                byte[] dataLenArr = new byte[4];
                cmdArr[0] = arr[0];
                cmdArr[1] = arr[1];
                dataLenArr[0] = arr[2];
                dataLenArr[1] = arr[3];
                dataLenArr[2] = arr[4];
                dataLenArr[3] = arr[5];
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(cmdArr);
                    Array.Reverse(dataLenArr);
                }
                var cmd = BitConverter.ToInt16(cmdArr, 0);
                var datalen = BitConverter.ToInt32(dataLenArr, 0);

                bs.RemoveRange(0, 6);
                var dataArr = bs.ToArray();
                //发送过来的消息
                if (onData != null)
                {
                    onData(cmd, dataArr);
                }
                //清空消息容器
                bs = new List<byte>();
            }
            //继续监听Socket信息
            result = await socketClient.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            checkDisConnect(result);
        }
    }

}