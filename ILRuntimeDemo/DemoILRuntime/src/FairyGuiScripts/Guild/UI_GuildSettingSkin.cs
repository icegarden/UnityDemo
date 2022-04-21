/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildSettingSkin : GComponent
    {
        public GLabel m_bg;
        public UI_GuildLogoIconSkin m_comp_logo;
        public GImage m_n5;
        public GImage m_n9;
        public GImage m_n13;
        public GImage m_n19;
        public GImage m_n24;
        public GTextField m_txt_name;
        public GTextField m_txt_title1;
        public GTextField m_txt_title2;
        public GTextField m_txt_title3;
        public GTextField m_txt_title4;
        public GTextInput m_txt_joinNotice;
        public GTextField m_txt_level;
        public GButton m_btn_change;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GButton m_btn_Join1;
        public GButton m_btn_Join2;
        public GSlider m_btn_slide;
        public GButton m_btn_cname;
        public GGroup m_n22;
        public const string URL = "ui://tae9x4e9yfnam";

        public static UI_GuildSettingSkin CreateInstance()
        {
            return (UI_GuildSettingSkin)UIPackage.CreateComponet("Guild", "GuildSettingSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_comp_logo = (UI_GuildLogoIconSkin)GetChildComAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_n9 = (GImage)GetChildAt(3);
            m_n13 = (GImage)GetChildAt(4);
            m_n19 = (GImage)GetChildAt(5);
            m_n24 = (GImage)GetChildAt(6);
            m_txt_name = (GTextField)GetChildAt(7);
            m_txt_title1 = (GTextField)GetChildAt(8);
            m_txt_title2 = (GTextField)GetChildAt(9);
            m_txt_title3 = (GTextField)GetChildAt(10);
            m_txt_title4 = (GTextField)GetChildAt(11);
            m_txt_joinNotice = (GTextInput)GetChildAt(12);
            m_txt_level = (GTextField)GetChildAt(13);
            m_btn_change = (GButton)GetChildComAt(14);
            m_btn_confirm = (GButton)GetChildComAt(15);
            m_btn_cancel = (GButton)GetChildComAt(16);
            m_btn_Join1 = (GButton)GetChildComAt(17);
            m_btn_Join2 = (GButton)GetChildComAt(18);
            m_btn_slide = (GSlider)GetChildComAt(19);
            m_btn_cname = (GButton)GetChildComAt(20);
            m_n22 = (GGroup)GetChildAt(21);
        }
    }
}