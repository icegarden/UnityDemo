/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_ServerItemSkin : GButton
    {
        public Controller m_button;
        public GImage m_n10;
        public GImage m_n11;
        public GLoader m_img_state;
        public GTextField m_txt_name;
        public const string URL = "ui://o08pjsz8rb88q";

        public static UI_ServerItemSkin CreateInstance()
        {
            return (UI_ServerItemSkin)UIPackage.CreateComponet("Login", "ServerItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n10 = (GImage)GetChildAt(0);
            m_n11 = (GImage)GetChildAt(1);
            m_img_state = (GLoader)GetChildAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
        }
    }
}