using System;
using System.Collections.Generic;
using UnityGameFramework.Runtime;
using UnityEngine;
public class BaseConfig : IConfig
{
    private static Dictionary<string, Type> decoders;
    private static Dictionary<Type, IConfig> configs;
    public static void Init()
    {
        configs = new Dictionary<Type, IConfig>();
        decoders = new Dictionary<string, Type>();
        decoders.Add("Preload", typeof(PreLoadConfig));
        decoders.Add("Item", typeof(ItemConfig));
    }

    public static void DecodeCfg(string name, object obj)
    {
        Type tmp;
        decoders.TryGetValue(name, out tmp);
        if (tmp != null)
        {
            var text = (string)obj.GetType().GetProperty("text").GetValue(obj);
            if (text.StartsWith("["))
            {
                //纯数组类型的json
                text = "{\"allItems\":" + text + "}";
            }
            var  reader = new LitJson.JsonReader(text);
            IConfig cfg = (IConfig)LitJson.JsonMapper.ReadValue(tmp, reader);
            cfg.Parse();
            configs.Add(tmp, cfg);
        }
    }

    public static T GetConfig<T>() where T : IConfig
    {
        Type tmp = typeof(T);
        IConfig value;
        configs.TryGetValue(tmp, out value);
        return (T)value;
    }

    public void Parse()
    {

    }
}


