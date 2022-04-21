/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingNameSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n2;
        public GTextInput m_txt_input;
        public GTextField m_txt_free;
        public GComponent m_cost;
        public GButton m_btn_confirm;
        public GButton m_btn_random;
        public const string URL = "ui://wi3k1s54j3xs16";

        public static UI_SettingNameSkin CreateInstance()
        {
            return (UI_SettingNameSkin)UIPackage.CreateComponet("Setting", "SettingNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_input = (GTextInput)GetChildAt(2);
            m_txt_free = (GTextField)GetChildAt(3);
            m_cost = (GComponent)GetChildComAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_random = (GButton)GetChildComAt(6);
        }
    }
}