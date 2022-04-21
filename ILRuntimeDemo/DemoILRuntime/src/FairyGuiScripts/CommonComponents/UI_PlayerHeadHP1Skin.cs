/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerHeadHP1Skin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public GLoader m_img_slot;
        public UI_CommonBarSkin m_pb_hp;
        public const string URL = "ui://0qeyzr63cnj39";

        public static UI_PlayerHeadHP1Skin CreateInstance()
        {
            return (UI_PlayerHeadHP1Skin)UIPackage.CreateComponet("CommonComponents", "PlayerHeadHP1Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_pb_hp = (UI_CommonBarSkin)GetChildComAt(3);
        }
    }
}