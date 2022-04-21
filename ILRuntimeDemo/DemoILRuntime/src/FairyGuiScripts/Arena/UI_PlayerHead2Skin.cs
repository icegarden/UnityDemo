/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_PlayerHead2Skin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public GLoader m_img_slot;
        public GImage m_n9;
        public GTextField m_txt_power;
        public const string URL = "ui://m8qegzmncnj36";

        public static UI_PlayerHead2Skin CreateInstance()
        {
            return (UI_PlayerHead2Skin)UIPackage.CreateComponet("Arena", "PlayerHead2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_n9 = (GImage)GetChildAt(3);
            m_txt_power = (GTextField)GetChildAt(4);
        }
    }
}