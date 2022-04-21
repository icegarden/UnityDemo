using System;
using System.Collections.Generic;

namespace ET
{
    [ObjectSystem]
    public class OpcodeTypeComponentAwakeSystem: AwakeSystem<OpcodeTypeComponent>
    {
        public override void Awake(OpcodeTypeComponent self)
        {
            Log.Info("OpcodeTypeComponentAwakeSystem");
            OpcodeTypeComponent.Instance = self;
            self.Awake();
        }
    }

    [ObjectSystem]
    public class OpcodeTypeComponentDestroySystem: DestroySystem<OpcodeTypeComponent>
    {
        public override void Destroy(OpcodeTypeComponent self)
        {
            OpcodeTypeComponent.Instance = null;
        }
    }

    public class OpcodeTypeComponent: Entity, IAwake, IDestroy
    {
        public static OpcodeTypeComponent Instance;
        
        private HashSet<short> outrActorMessage = new HashSet<short>();
        
        private readonly Dictionary<short, Type> opcodeTypes = new Dictionary<short, Type>();
        private readonly Dictionary<Type, short> typeOpcodes = new Dictionary<Type, short>();
        
        private readonly Dictionary<Type, Type> requestResponse = new Dictionary<Type, Type>();
        
        public void Awake()
        {
            this.opcodeTypes.Clear();
            this.typeOpcodes.Clear();
            this.requestResponse.Clear();

            List<Type> types = EventSystem.Instance.GetTypes(typeof (MessageAttribute));
            var len = types.Count;
            for(var i= 0; i < len; i++)
            {
                var type = types[i];
                object[] attrs = type.GetCustomAttributes(typeof (MessageAttribute), false);
                if (attrs.Length == 0)
                {
                    continue;
                }

                MessageAttribute messageAttribute = attrs[0] as MessageAttribute;
                if (messageAttribute == null)
                {
                    continue;
                }
                

                this.opcodeTypes.Add(messageAttribute.Opcode, type);
                this.typeOpcodes.Add(type, messageAttribute.Opcode);

            }
        }

        public bool IsOutrActorMessage(short opcode)
        {
            return this.outrActorMessage.Contains(opcode);
        }

        public short GetOpcode(Type type)
        {
            return this.typeOpcodes[type];
        }

        public Type GetType(short opcode)
        {
            return this.opcodeTypes[opcode];
        }

        public Type GetResponseType(Type request)
        {
            if (!this.requestResponse.TryGetValue(request, out Type response))
            {
                throw new Exception($"not found response type, request type: {request.GetType().Name}");
            }
            return response;
        }
    }
}