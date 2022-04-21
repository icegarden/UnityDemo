using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ET
{
    [ObjectSystem]
    public class SessionAwakeSystem: AwakeSystem<Session, AService>
    {
        public override void Awake(Session self, AService aService)
        {
            self.Awake(aService);
        }
    }

    public sealed class Session: Entity, IAwake<AService>
    {

        public Action onConnectCall;
        public Action onDisconnectCall;
        public Action<short, object> onDataCall;
        private readonly struct RpcInfo
        {
            public readonly IRequest Request;
            public readonly ETTask<IResponse> Tcs;

            public RpcInfo(IRequest request)
            {
                this.Request = request;
                this.Tcs = ETTask<IResponse>.Create(true);
            }
        }

        public AService AService;
        

        private readonly Dictionary<int, RpcInfo> requestCallbacks = new Dictionary<int, RpcInfo>();
        
        public long LastRecvTime
        {
            get;
            set;
        }

        public long LastSendTime
        {
            get;
            set;
        }

        public int Error
        {
            get;
            set;
        }

        public void Awake(AService aService)
        {
            this.AService = aService;
            long timeNow = TimeHelper.ClientNow();
            this.LastRecvTime = timeNow;
            this.LastSendTime = timeNow;

            this.requestCallbacks.Clear();
            
            Log.Info($"session create: id: {this.Id} {timeNow} ");
        }

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            long id = this.Id;

            base.Dispose();

            this.AService.RemoveChannel(this.Id);
            

            Log.Info($"session dispose: {this.RemoteAddress} id: {id} ErrorCode: {this.Error}, please see ErrorCode.cs! {TimeHelper.ClientNow()}");

            this.requestCallbacks.Clear();
        }

        public IPEndPoint RemoteAddress
        {
            get;
            set;
        }


        public void Send(IMessage message)
        {
            (short opcode, MemoryStream stream) = MessageSerializeHelper.MessageToStream(message);
            this.Send(opcode, stream);
        }
        
        
        private void Send(short cmd, MemoryStream memoryStream)
        {
            this.LastSendTime = TimeHelper.ClientNow();
            this.AService.SendStream(this.Id, cmd, memoryStream);
        }
    }
}