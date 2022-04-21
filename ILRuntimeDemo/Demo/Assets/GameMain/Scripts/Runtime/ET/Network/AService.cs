using System;
using System.IO;
using System.Net;

namespace ET
{
    public abstract class AService: IDisposable
    {
        
        public ThreadSynchronizationContext ThreadSynchronizationContext;
        
        // localConn放在低32bit
        private long connectIdGenerater = int.MaxValue;
        public long CreateConnectChannelId(uint localConn)
        {
            return (--this.connectIdGenerater << 32) | localConn;
        }
        
        public uint CreateRandomLocalConn()
        {
            return (1u << 30) | RandomHelper.RandUInt32();
        }

        // localConn放在低32bit
        private long acceptIdGenerater = 1;
        public long CreateAcceptChannelId(uint localConn)
        {
            return (++this.acceptIdGenerater << 32) | localConn;
        }



        public abstract void Update();

        public abstract void Remove(long id);
        
        public abstract bool IsDispose();

        protected abstract void Get(long id, IPEndPoint address);

        public abstract void Dispose();

        protected abstract void Send(long channelId, short cmd, MemoryStream stream);
        
        protected void OnAccept(long channelId, IPEndPoint ipEndPoint)
        {
            this.AcceptCallback.Invoke(channelId, ipEndPoint);
        }

        public void OnRead(long channelId, MemoryStream memoryStream)
        {
            this.ReadCallback.Invoke(channelId, memoryStream);
        }

        public void OnError(long channelId, int e)
        {
            this.Remove(channelId);
            
            this.ErrorCallback?.Invoke(channelId, e);
        }

        
        public Action<long, IPEndPoint> AcceptCallback;
        public Action<long, int> ErrorCallback;
        public Action<long, MemoryStream> ReadCallback;
        public Action<long> ConnectCallBack;
        public Action<long> DisconnectCallBack;

        public void OnConnect(long channelId)
        {
            this.ConnectCallBack?.Invoke(channelId);
        }

        public void OnDisconnect(long channelId)
        {
            this.DisconnectCallBack?.Invoke(channelId);
        }
        public void Destroy()
        {
            this.Dispose();
        }

        public void RemoveChannel(long channelId)
        {
            this.Remove(channelId);
        }

        public void SendStream(long channelId, short cmd, MemoryStream stream)
        {
            this.Send(channelId, cmd, stream);
        }

        public void GetOrCreate(long id, IPEndPoint address)
        {
            this.Get(id, address);
        }
    }
}