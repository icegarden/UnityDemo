using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class ResourceUtil
    {
        public  delegate void LoadSuccess();
        public  delegate void LoadFailure();
        public static  void LoadBundleContent(string uri, LoadSuccess success,LoadFailure fail)
        {
            
        }
    }
}
