/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_LoginSkin : GComponent
    {
        public GLoader m_bg;
        public GImage m_n8;
        public GButton m_btn_account;
        public GButton m_btn_bulletin;
        public GTextField m_txt_notice;
        public GTextField m_txt_serverName;
        public GTextField m_txt_changeServer;
        public GLoader m_img_serverState;
        public GGraph m_sp_changeServer;
        public GButton m_btn_start;
        public const string URL = "ui://o08pjsz8c6ya1";

        public static UI_LoginSkin CreateInstance()
        {
            return (UI_LoginSkin)UIPackage.CreateComponet("Login", "LoginSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_n8 = (GImage)GetChildAt(1);
            m_btn_account = (GButton)GetChildComAt(2);
            m_btn_bulletin = (GButton)GetChildComAt(3);
            m_txt_notice = (GTextField)GetChildAt(4);
            m_txt_serverName = (GTextField)GetChildAt(5);
            m_txt_changeServer = (GTextField)GetChildAt(6);
            m_img_serverState = (GLoader)GetChildAt(7);
            m_sp_changeServer = (GGraph)GetChildAt(8);
            m_btn_start = (GButton)GetChildComAt(9);
        }
    }
}