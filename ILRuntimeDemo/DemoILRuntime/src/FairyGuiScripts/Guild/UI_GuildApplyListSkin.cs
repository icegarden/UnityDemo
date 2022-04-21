/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildApplyListSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public GList m_list_apply;
        public GButton m_btn_agreeAll;
        public GButton m_btn_ignoreAll;
        public GImage m_n5;
        public GImage m_n8;
        public GTextField m_txt_empty;
        public GTextField m_txt0;
        public GTextField m_txt_count;
        public GImage m_n9;
        public const string URL = "ui://tae9x4e9yfna1b";

        public static UI_GuildApplyListSkin CreateInstance()
        {
            return (UI_GuildApplyListSkin)UIPackage.CreateComponet("Guild", "GuildApplyListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_list_apply = (GList)GetChildComAt(1);
            m_btn_agreeAll = (GButton)GetChildComAt(2);
            m_btn_ignoreAll = (GButton)GetChildComAt(3);
            m_n5 = (GImage)GetChildAt(4);
            m_n8 = (GImage)GetChildAt(5);
            m_txt_empty = (GTextField)GetChildAt(6);
            m_txt0 = (GTextField)GetChildAt(7);
            m_txt_count = (GTextField)GetChildAt(8);
            m_n9 = (GImage)GetChildAt(9);
        }
    }
}