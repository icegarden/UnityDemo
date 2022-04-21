/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_SelectServerSkin : GComponent
    {
        public Controller m_tab;
        public GLabel m_bg;
        public GImage m_n18;
        public GButton m_btn_mine;
        public GButton m_btn_recommend;
        public GButton m_btn_others;
        public GTextField m_txt_lastServer;
        public GList m_list_server;
        public const string URL = "ui://o08pjsz8c6ya4";

        public static UI_SelectServerSkin CreateInstance()
        {
            return (UI_SelectServerSkin)UIPackage.CreateComponet("Login", "SelectServerSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n18 = (GImage)GetChildAt(1);
            m_btn_mine = (GButton)GetChildComAt(2);
            m_btn_recommend = (GButton)GetChildComAt(3);
            m_btn_others = (GButton)GetChildComAt(4);
            m_txt_lastServer = (GTextField)GetChildAt(5);
            m_list_server = (GList)GetChildComAt(6);
        }
    }
}