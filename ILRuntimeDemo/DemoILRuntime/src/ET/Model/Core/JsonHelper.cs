using System;

namespace ET
{
    public static class JsonHelper
    {
        public static string ToJson(object message)
        {
            return LitJson.JsonMapper.ToJson(message);
        }
        
        public static object FromJson(Type type, string json)
        {
            var reader = new LitJson.JsonReader(json);
            return  LitJson.JsonMapper.ReadValue(type, reader);
        }
        
        public static T FromJson<T>(string json)
        {
            return LitJson.JsonMapper.ToObject<T>(json);
        }
    }
}