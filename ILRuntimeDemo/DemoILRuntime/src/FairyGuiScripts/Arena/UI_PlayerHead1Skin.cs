/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_PlayerHead1Skin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public GLoader m_img_slot;
        public const string URL = "ui://m8qegzmnl1me14";

        public static UI_PlayerHead1Skin CreateInstance()
        {
            return (UI_PlayerHead1Skin)UIPackage.CreateComponet("Arena", "PlayerHead1Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
        }
    }
}