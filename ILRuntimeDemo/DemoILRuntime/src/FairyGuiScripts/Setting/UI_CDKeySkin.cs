/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_CDKeySkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n2;
        public GTextInput m_txt_input;
        public GButton m_btn_cancel;
        public GButton m_btn_confirm;
        public const string URL = "ui://wi3k1s54j3xsz";

        public static UI_CDKeySkin CreateInstance()
        {
            return (UI_CDKeySkin)UIPackage.CreateComponet("Setting", "CDKeySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_input = (GTextInput)GetChildAt(2);
            m_btn_cancel = (GButton)GetChildComAt(3);
            m_btn_confirm = (GButton)GetChildComAt(4);
        }
    }
}