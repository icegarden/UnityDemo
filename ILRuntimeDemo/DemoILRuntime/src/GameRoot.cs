using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class GameRoot
    {
        public static Options Options;
        public static TimeInfo TimeInfo;

        public static ThreadSynchronizationContext ThreadSynchronizationContext => ThreadSynchronizationContext.Instance;

        private static bool _inited=false;
       public static void Init()
        {
            Options.Instance = new Options();
            Options.Instance.LogLevel = 0;
            GameRoot.Options = Options.Instance;
            TimeInfo = TimeInfo.Instance;
            EventSystem.Instance.Add(Game.allTypes);
            LayerManager.Init();
            ModuleManager.Init();
            RegistService.Init();
            BaseConfig.Init();
            Preload.GetInstance().Start();
            new NetService();
            _inited = true;
        }

        public static void Update()
        {
            if (!_inited)
            {
                return;
            }
            ThreadSynchronizationContext.Update();
            TimeInfo.Instance.Update();
            EventSystem.Instance.Update();
        }

        public static void LateUpdate()
        {
            if (!_inited)
            {
                return;
            }
            EventSystem.Instance.LateUpdate();
        }

        public static void FixedUpdate()
        {
            if (!_inited)
            {
                return;
            }
        }
    }
}
