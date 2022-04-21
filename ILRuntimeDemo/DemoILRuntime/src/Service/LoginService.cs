using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class LoginService : BaseService
    {
        private static LoginService _ins;
        public static LoginService Instance
        {
            get
            {
                if (_ins == null) { _ins = new LoginService(); }
                return _ins;
            }
        }

        public override void OnRegist()
        {

            this.RegistCmdHandler(CMD.GetUser_S, OnGetUser_S);
        }

        private void OnGetUser_S(object obj)
        {
            
        }

        public override void OnConnect()
        {
            var msg = new GetUser_C();
            msg.puid = "aabc12";
            this.SendMessage(msg);
        }
        
    }
}
