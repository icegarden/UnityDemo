using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class NetWebSocketComponent:Entity, IAwake<int>, IDestroy
    {
        public AService Service;
        public int SessionStreamDispatcherType { get; set; }
    }
}
