/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildListSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n4;
        public GImage m_n2;
        public GTextInput m_txt_search;
        public GButton m_btn_refresh;
        public GButton m_btn_search;
        public GButton m_btn_create;
        public GTextField m_txt_title0;
        public GTextField m_txt_title1;
        public GTextField m_txt_title2;
        public GTextField m_txt_title3;
        public GTextField m_txt_title4;
        public GList m_list_guild;
        public const string URL = "ui://tae9x4e9yfnae";

        public static UI_GuildListSkin CreateInstance()
        {
            return (UI_GuildListSkin)UIPackage.CreateComponet("Guild", "GuildListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_txt_search = (GTextInput)GetChildAt(3);
            m_btn_refresh = (GButton)GetChildComAt(4);
            m_btn_search = (GButton)GetChildComAt(5);
            m_btn_create = (GButton)GetChildComAt(6);
            m_txt_title0 = (GTextField)GetChildAt(7);
            m_txt_title1 = (GTextField)GetChildAt(8);
            m_txt_title2 = (GTextField)GetChildAt(9);
            m_txt_title3 = (GTextField)GetChildAt(10);
            m_txt_title4 = (GTextField)GetChildAt(11);
            m_list_guild = (GList)GetChildComAt(12);
        }
    }
}