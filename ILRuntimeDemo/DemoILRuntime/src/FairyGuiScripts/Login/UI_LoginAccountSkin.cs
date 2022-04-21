/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_LoginAccountSkin : GComponent
    {
        public GLabel m_bg_account;
        public GImage m_n12;
        public GTextField m_txt_accoutTitle;
        public GTextInput m_txt_userName;
        public GButton m_btn_login;
        public const string URL = "ui://o08pjsz8j3xs1e";

        public static UI_LoginAccountSkin CreateInstance()
        {
            return (UI_LoginAccountSkin)UIPackage.CreateComponet("Login", "LoginAccountSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg_account = (GLabel)GetChildComAt(0);
            m_n12 = (GImage)GetChildAt(1);
            m_txt_accoutTitle = (GTextField)GetChildAt(2);
            m_txt_userName = (GTextInput)GetChildAt(3);
            m_btn_login = (GButton)GetChildComAt(4);
        }
    }
}