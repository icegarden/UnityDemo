using System;
using System.Collections.Generic;
using FairyGUI;

namespace DemoILRuntime
{
    public class ModuleManager
    {
        public static Dictionary<ModuleId, Type> _clsDic;
        private static Dictionary<ModuleId, Mediator<GComponent>> _insDic;
        public static void Init()
        {
            _clsDic = new Dictionary<ModuleId, Type>();
            _insDic = new Dictionary<ModuleId,Mediator<GComponent>>();
            RegistMediator.Init(_clsDic);
        }

        public static void Open(ModuleId Id)
        {
            Mediator<GComponent> _ins;
            _insDic.TryGetValue(Id, out _ins);
            if (_ins != null)
            {
                _ins.awake();
                return;
            }
            Type _type;
            _clsDic.TryGetValue(Id, out _type);
            if(_type != null)
            {
                _ins = (Mediator<GComponent>)Activator.CreateInstance(_type);
                _insDic[Id] = _ins;
                _ins.awake();
            }
            else
            {
                UnityEngine.Debug.LogWarning("没有注册Mediator:"+Id);
            }
        }

        public static void Close(ModuleId Id)
        {
            Mediator<GComponent> _ins;
            _insDic.TryGetValue(Id, out _ins);
            if (_ins != null)
            {
                _ins.sleep();
                return;
            }
        }
    }
}
