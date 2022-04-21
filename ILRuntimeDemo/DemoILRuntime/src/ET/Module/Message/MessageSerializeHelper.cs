using System;
using System.IO;

namespace ET
{
    public static class MessageSerializeHelper
    {
        public static object DeserializeFrom(short opcode, Type type, MemoryStream memoryStream)
        {
           return ProtobufHelper.FromStream(type, memoryStream);
        }

        public static void SerializeTo(short cmd, object obj, MemoryStream memoryStream)
        {
            try
            {
               ProtobufHelper.ToStream(obj, memoryStream);
            }
            catch (Exception e)
            {
                throw new Exception($"SerializeTo error: {cmd}", e);
            }

        }

        public static MemoryStream GetStream(int count = 0)
        {
            MemoryStream stream;
            if (count > 0)
            {
                stream = new MemoryStream(count);
            }
            else
            {
                stream = new MemoryStream();
            }

            return stream;
        }
        
        public static (short, MemoryStream) MessageToStream(object message)
        {
            MemoryStream stream = GetStream(0);
            short cmd = OpcodeTypeComponent.Instance.GetOpcode(message.GetType());
            MessageSerializeHelper.SerializeTo(cmd, message, stream);
            return (cmd, stream);
        }
    }
}