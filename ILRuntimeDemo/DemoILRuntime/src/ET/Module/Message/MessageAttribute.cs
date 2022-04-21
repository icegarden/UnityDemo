namespace ET
{
    public class MessageAttribute: BaseAttribute
    {
        public short Opcode
        {
            get;
        }

        public MessageAttribute(short opcode)
        {
            this.Opcode = opcode;
        }
    }
}