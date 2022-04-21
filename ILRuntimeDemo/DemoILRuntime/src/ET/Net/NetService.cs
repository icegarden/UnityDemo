using System;
using System.Collections.Generic;
using ET;

namespace DemoILRuntime
{
    public class NetService
    {
        private static NetService _ins;
        protected Session netSession;
        private Dictionary<short, Action<object>> _listeners;

        private List<Action> _connectCalls;
        private List<Action> _disconnectCalls;
        private List<Action> _reconnectCalls;

        public static NetService Instance 
        { 
            get 
            {
                if(_ins == null)
                {
                    _ins = new NetService();
                }
                return _ins;
            } 
        }
        public NetService()
        {
            _listeners = new Dictionary<short, Action<object>>();
            _connectCalls = new List<Action>();
            _disconnectCalls = new List<Action>();
            _reconnectCalls = new List<Action>();

        }

        public void Connect(string ip,int port)
        {
            Scene scene = EntitySceneFactory.CreateScene(IdGenerater.Instance.GenerateInstanceId(), 0, SceneType.Process, "Process");

            scene.AddComponent<OpcodeTypeComponent>();
            scene.AddComponent<NetThreadComponent>();

            Scene zoneScene = EntitySceneFactory.CreateScene(IdGenerater.Instance.GenerateInstanceId(), 1, SceneType.Zone, "Game", scene);

            zoneScene.AddComponent<NetWebSocketComponent, int>(SessionStreamDispatcherType.SessionStreamDispatcherClientOuter);

            Session session = zoneScene.GetComponent<NetWebSocketComponent>().Create(ip, port);

            session.onConnectCall = OnSocketConnect;
            session.onDisconnectCall = OnSocketDisconnectCall;
            session.onDataCall = OnDataCall;
            netSession = session;

           // var service = new WService();
        }

        public void AddConnectCalls(Action action)
        {
            _connectCalls.Add(action);
        }

        public void AddDisconnectCalls(Action action)
        {
            _disconnectCalls.Add(action);
        }

        public void AddReconnectCalls(Action action)
        {
            _reconnectCalls.Add(action);
        }

        public void AddCmdHandler(short cmd, Action<object> action)
        {
            Action<object> action2;
            _listeners.TryGetValue(cmd, out action2);
            if(action2 == null)
            {
                _listeners.Add(cmd, action);
            }
            else
            {
                Log.Info($"重复为cmd:{cmd}注册了处理函数");
            }
        }

        public void Send(IMessage msg)
        {
            netSession.Send(msg);
        }

        private void OnSocketConnect()
        {
            Log.Info("socket连接成功");
            var len = _connectCalls.Count;
            for(var i = 0; i < len; i++)
            {
                var call = _connectCalls[i];
                if(call != null)
                {
                    call.Invoke();
                }
            }
        }

        private void OnSocketDisconnectCall()
        {
            Log.Info("socket断开连接");
            var len = _disconnectCalls.Count;
            for (var i = 0; i < len; i++)
            {
                var call = _disconnectCalls[i];
                if (call != null)
                {
                    call.Invoke();
                }
            }
        }

        private void OnDataCall(short cmd, object data)
        {
            Action<object> callBack;
            Log.Info($"回调cmd:{cmd},数据：{LitJson.JsonMapper.ToJson(data)}");
            _listeners.TryGetValue(cmd, out callBack);
            if(callBack != null)
            {
                callBack.Invoke(data);
            }
        }
    }
}
