using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public abstract class BaseService
    {
        public abstract void OnRegist();
       

        public BaseService()
        {
            NetService.Instance.AddConnectCalls(OnConnect);
            NetService.Instance.AddDisconnectCalls(OnDisconnect);
            NetService.Instance.AddReconnectCalls(OnReconnect);
        }
        public void RegistCmdHandler(short cmd, Action<object> action)
        {

            NetService.Instance.AddCmdHandler(cmd, action);
        }


        protected void SendMessage(IMessage msg)
        {
            NetService.Instance.Send(msg);
        }

        public virtual void OnConnect()
        {
        }
        public virtual void OnDisconnect()
        {
        }

        public virtual void OnReconnect()
        {
        }
    }
}
