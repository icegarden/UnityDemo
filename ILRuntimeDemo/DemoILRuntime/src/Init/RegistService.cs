using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class RegistService
    {
        public static void Init()
        {
            LoginService.Instance.OnRegist();
        }
    }
}
