/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingHeadItemSkin : GButton
    {
        public Controller m_state;
        public Controller m_button;
        public GImage m_n1;
        public GLoader m_img_head;
        public GImage m_n0;
        public GImage m_n3;
        public GImage m_n4;
        public GImage m_n5;
        public GImage m_n6;
        public GTextField m_txt_using;
        public const string URL = "ui://wi3k1s54j3xsu";

        public static UI_SettingHeadItemSkin CreateInstance()
        {
            return (UI_SettingHeadItemSkin)UIPackage.CreateComponet("Setting", "SettingHeadItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_button = GetControllerAt(1);
            m_n1 = (GImage)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_n0 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_n5 = (GImage)GetChildAt(5);
            m_n6 = (GImage)GetChildAt(6);
            m_txt_using = (GTextField)GetChildAt(7);
        }
    }
}