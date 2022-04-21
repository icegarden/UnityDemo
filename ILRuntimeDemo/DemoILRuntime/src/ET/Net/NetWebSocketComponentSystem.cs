using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [FriendClass(typeof(NetThreadComponent))]
    [ObjectSystem]
    public class NetWebSocketComponentAwakeSystem : AwakeSystem<NetWebSocketComponent,int>
    {
        public override void Awake(NetWebSocketComponent self, int sessionStreamDispatcherType)
        {
            self.SessionStreamDispatcherType = sessionStreamDispatcherType;
            self.Service = new WService(NetThreadComponent.Instance.ThreadSynchronizationContext);
            self.Service.ErrorCallback += (channelId, error) => self.OnError(channelId, error);
            self.Service.ReadCallback += (channelId, Memory) => self.OnRead(channelId, Memory);
            self.Service.ConnectCallBack += (channelId) => self.OnConnect(channelId);
            self.Service.DisconnectCallBack += (channelId) => self.OnDisconnect(channelId);

            NetThreadComponent.Instance.Add(self.Service);
        }

        
       
    }

    

    [ObjectSystem]
    public class NetWebSocketComponentDestroySystem : DestroySystem<NetWebSocketComponent>
    {
        public override void Destroy(NetWebSocketComponent self)
        {
            NetThreadComponent.Instance.Remove(self.Service);
            self.Service.Destroy();
        }
    }

    [FriendClass(typeof(NetWebSocketComponent))]
    public static class NetWebSocketComponentSystem
    {
        public static void OnRead(this NetWebSocketComponent self, long channelId, MemoryStream memoryStream)
        {
            Session session = self.GetChild<Session>(channelId);
            if (session == null)
            {
                return;
            }

            session.LastRecvTime = TimeHelper.ClientNow();

            var totalLen = memoryStream.Length;
            byte[] buffer = new byte[totalLen];
            memoryStream.Read(buffer,0,(int)totalLen);

            //字节序转换
            short opcode = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(buffer, 0));
            int dataLen = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(buffer, 2));

            var stream = new MemoryStream(buffer,6,dataLen);

            Type type = OpcodeTypeComponent.Instance.GetType(opcode);

            object message = MessageSerializeHelper.DeserializeFrom(opcode, type, stream);

            session.onDataCall?.Invoke(opcode, message);
        }

        public static void OnError(this NetWebSocketComponent self, long channelId, int error)
        {
            Session session = self.GetChild<Session>(channelId);
            if (session == null)
            {
                return;
            }
            if(error == ErrorCore.ERR_WebsocketPeerReset)
            {
                self.OnDisconnect(channelId);
            }
            session.Error = error;
            session.Dispose();
        }

        public static void OnConnect(this NetWebSocketComponent self, long channelId)
        {
            
            Session session = self.GetChild<Session>(channelId);
            session.onConnectCall?.Invoke();
        }

        public static void OnDisconnect(this NetWebSocketComponent self, long channelId)
        {
            Session session = self.GetChild<Session>(channelId);
           session.onDisconnectCall?.Invoke();
        }


        public static Session Create(this NetWebSocketComponent self, string host,int port)
        {
            long channelId = RandomHelper.RandInt64();
            Session session = self.AddChildWithId<Session, AService>(channelId, self.Service);
            var ipEndPoint = new IPEndPoint(IPAddress.Parse(host), port);
            session.RemoteAddress = ipEndPoint;
            session.AddComponent<SessionIdleCheckerComponent, int>(NetThreadComponent.checkInteral);
            var uri = "ws://" + host + ":" + port;
            ((WService)self.Service).Create(uri, session.Id);
            return session;
        }
    }
}
