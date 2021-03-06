using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Threading;

namespace ET
{
    public class WChannel: AChannel
    {
        public HttpListenerWebSocketContext WebSocketContext { get; }

        private readonly WService Service;

        private readonly WebSocket webSocket;

        private readonly Queue<byte[]> queue = new Queue<byte[]>();

        private bool isSending;

        private bool isConnected;


        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        private readonly CircularBuffer sendBuffer = new CircularBuffer();

        private readonly byte[] sendCache = new byte[Packet.OpcodeLength + Packet.DataLength];

        public WChannel(long id, HttpListenerWebSocketContext webSocketContext, WService service)
        {
            this.Id = id;
            this.Service = service;
            this.ChannelType = ChannelType.Accept;
            this.WebSocketContext = webSocketContext;
            this.webSocket = webSocketContext.WebSocket;

            isConnected = true;
            
            this.Service.ThreadSynchronizationContext.PostNext(()=>
            {
                this.StartRecv().Coroutine();
                this.StartSend().Coroutine();
            });
        }

        public WChannel(long id, WebSocket webSocket, string connectUrl, WService service)
        {
            this.Id = id;
            this.Service = service;
            this.ChannelType = ChannelType.Connect;
            this.webSocket = webSocket;

            isConnected = false;
            
            this.Service.ThreadSynchronizationContext.PostNext(()=>this.ConnectAsync(connectUrl).Coroutine());
        }

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            this.cancellationTokenSource.Cancel();
            this.cancellationTokenSource.Dispose();
            this.cancellationTokenSource = null;

            this.webSocket.Dispose();
        }

        public async ETTask ConnectAsync(string url)
        {
            try
            {
                await ((ClientWebSocket) this.webSocket).ConnectAsync(new Uri(url), cancellationTokenSource.Token);
                isConnected = true;
                this.OnConnect();
                this.StartRecv().Coroutine();
                this.StartSend().Coroutine();
            }
            catch (Exception e)
            {
                Log.Error(e);
                this.OnError(ErrorCore.ERR_WebsocketConnectError);
            }
        }

        public void Send(short cmd,MemoryStream stream)
        {
            //????????????????????????????????????
            int messageSize = (int)stream.Length;

            //???????????????
            this.sendCache.WriteTo(0, IPAddress.HostToNetworkOrder(cmd));//???????????????
            this.sendCache.WriteTo(Packet.OpcodeLength, IPAddress.HostToNetworkOrder(messageSize));//??????????????????

            this.sendBuffer.Write(this.sendCache, 0, Packet.DataLength + Packet.OpcodeLength);//???cache??????6??????????????????????????????sendBuffer???

            stream.Position = 0;
            this.sendBuffer.Write(stream.GetBuffer(), (int)stream.Position, (int)(stream.Length - stream.Position));

            int len = Packet.OpcodeLength + Packet.DataLength + messageSize;
            byte[] bytes = new byte[len];
            this.sendBuffer.Read(bytes, 0, len);

            this.queue.Enqueue(bytes);

            if (this.isConnected)
            {
                this.StartSend().Coroutine();
            }
        }

        public async ETTask StartSend()
        {
            if (this.IsDisposed)
            {
                return;
            }

            try
            {
                if (this.isSending)
                {
                    return;
                }

                this.isSending = true;

                while (true)
                {
                    if (this.queue.Count == 0)
                    {
                        this.isSending = false;
                        return;
                    }

                    byte[] bytes = this.queue.Dequeue();
                    try
                    {
                        await this.webSocket.SendAsync(new ArraySegment<byte>(bytes, 0, bytes.Length), WebSocketMessageType.Binary, true, cancellationTokenSource.Token);
                        if (this.IsDisposed)
                        {
                            return;
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Error(e);
                        this.OnError(ErrorCore.ERR_WebsocketSendError);
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
            }
        }

        private byte[] cache = new byte[1024];

        public async ETTask StartRecv()
        {
            if (this.IsDisposed)
            {
                return;
            }

            try
            {
                //??????????????????
                List<byte> bs = new List<byte>();
                WebSocketReceiveResult receiveResult;
                int receiveCount = 0;
                //?????????
                var buffer = new byte[1024];
                while (true)
                {

                    //???buffer????????????
                    receiveResult = await this.webSocket.ReceiveAsync(new ArraySegment<byte>(buffer),  cancellationTokenSource.Token);
                    if (this.IsDisposed)
                    {
                        return;
                    }
                    if (receiveResult.MessageType == WebSocketMessageType.Close)
                    {
                        this.OnDisconnect();
                        this.OnError(ErrorCore.ERR_WebsocketPeerReset);
                        return;
                    }

                    var len = receiveResult.Count;
                    var tmpbytes = new byte[len];
                    Array.Copy(buffer, tmpbytes, len);//???buffer??????len?????????tmpbytes???

                    bs.AddRange(tmpbytes);

                    receiveCount += receiveResult.Count;
                    if (receiveResult.EndOfMessage)
                    {
                        var stream = new MemoryStream(bs.ToArray());
                        this.OnRead(stream);
                        //??????????????????
                        bs = new List<byte>();
                        break;
                    }


                    
                }
            }
            catch (Exception e)
            {
                Log.Error(e);
                this.OnError(ErrorCore.ERR_WebsocketRecvError);
            }
        }
        
        private void OnRead(MemoryStream memoryStream)
        {
            try
            {
                long channelId = this.Id;
                this.Service.OnRead(channelId, memoryStream);
            }
            catch (Exception e)
            {
                Log.Error($"{this.RemoteAddress} {memoryStream.Length} {e}");
                // ??????????????????????????????????????????Session??????????????????????????????
                this.OnError(ErrorCore.ERR_PacketParserError);
            }
        }

        private void OnConnect()
        {
            this.Service.OnConnect(this.Id);
        }

        private void OnDisconnect()
        {
            this.Service.OnDisconnect(this.Id);
        }
        
        private void OnError(int error)
        {
            Log.Debug($"WChannel error: {error} {this.RemoteAddress}");
			
            long channelId = this.Id;
			
            this.Service.Remove(channelId);
			
            this.Service.OnError(channelId, error);
        }
    }
}