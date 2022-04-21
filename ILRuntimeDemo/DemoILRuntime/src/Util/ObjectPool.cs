using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class ObjectPool
    {
        private static Dictionary<string, List<IRecycle>> _poolDic = new Dictionary<string, List<IRecycle>>();
        private static Dictionary<string, List<object>> _normalDic = new Dictionary<string, List<object>>();

        public static T Get<T>()
        {
            var _type = typeof(T);
            if (!typeof(IRecycle).IsAssignableFrom(_type))
            {
                return GetNormal<T>();
            }
            var name = _type.FullName;
            List<IRecycle> poolList;
            _poolDic.TryGetValue(name, out poolList);
            if (poolList == null)
            {
                poolList = new List<IRecycle>();

                _poolDic.Add(name, poolList);
            }
            if (poolList.Count > 0)
            {
                var obj = poolList[0];
                obj.OnReuse();
                poolList.RemoveAt(0);
                return (T)obj;
            }
            var ins = (IRecycle)Activator.CreateInstance(_type);
            ins.OnReuse();
            return (T)ins;
        }

        public static object Get(Type _type)
        {
            var name = _type.FullName;
            if (!typeof(IRecycle).IsAssignableFrom(_type))
            {
                List<object> poolList;
                _normalDic.TryGetValue(name, out poolList);
                if (poolList == null)
                {
                    poolList = new List<object>();
                    _normalDic.Add(name, poolList);
                }
                if (poolList.Count > 0)
                {
                    var obj = poolList[0];
                    poolList.RemoveAt(0);
                    return obj;
                }
                var ins = Activator.CreateInstance(_type);
                return ins;
            }
            else
            {
                List<IRecycle> poolList;
                _poolDic.TryGetValue(name, out poolList);
                if (poolList == null)
                {
                    poolList = new List<IRecycle>();

                    _poolDic.Add(name, poolList);
                }
                if (poolList.Count > 0)
                {
                    var obj = poolList[0];
                    obj.OnReuse();
                    poolList.RemoveAt(0);
                    return obj;
                }
                var ins = (IRecycle)Activator.CreateInstance(_type);
                ins.OnReuse();
                return ins;
            }
        }

        private static T GetNormal<T>()
        {
            var _type = typeof(T);
            var name = _type.FullName;
            List<object> poolList;
            _normalDic.TryGetValue(name, out poolList);
            if (poolList == null)
            {
                poolList = new List<object>();
                _normalDic.Add(name, poolList);
            }
            if (poolList.Count > 0)
            {
                var obj = poolList[0];
                poolList.RemoveAt(0);
                return (T)obj;
            }
            var ins = Activator.CreateInstance(_type);
            return (T)ins;
        }

        public static void Recycle(IRecycle ins)
        {
            var name = ins.GetType().FullName;
            List<IRecycle> poolList;
            _poolDic.TryGetValue(name, out poolList);
            if (poolList == null)
            {
                poolList = new List<IRecycle>();
                _poolDic.Add(name, poolList);
            }
            ins.OnRecycle();
            poolList.Add(ins);
        }

        public static void Recycle(object ins)
        {
            var _type = ins.GetType();
            var name = _type.FullName;
            List<object> poolList;
            _normalDic.TryGetValue(name, out poolList);
            if (poolList == null)
            {
                poolList = new List<object>();
                _normalDic.Add(name, poolList);
            }
            poolList.Add(ins);

        }
    }
}
