/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildHallSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_bg_list1;
        public GLoader m_bg_list2;
        public GImage m_n13;
        public GImage m_n28;
        public GList m_list_member;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GLabel m_title;
        public UI_GuildLogoIconSkin m_comp_logo;
        public UI_GuildActiveValueSkin m_comp_activeValue;
        public GButton m_btn_manager;
        public GButton m_btn_log;
        public GProgressBar m_exp;
        public GTextField m_txt_title1;
        public GTextField m_txt_guildName;
        public GRichTextField m_txt_id;
        public GTextField m_txt_count;
        public GTextField m_txt_title0;
        public GTextField m_txt_notice;
        public const string URL = "ui://tae9x4e9yfnah";

        public static UI_GuildHallSkin CreateInstance()
        {
            return (UI_GuildHallSkin)UIPackage.CreateComponet("Guild", "GuildHallSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_bg_list1 = (GLoader)GetChildAt(1);
            m_bg_list2 = (GLoader)GetChildAt(2);
            m_n13 = (GImage)GetChildAt(3);
            m_n28 = (GImage)GetChildAt(4);
            m_list_member = (GList)GetChildComAt(5);
            m_img_bottom = (GLoader)GetChildAt(6);
            m_btn_back = (GButton)GetChildComAt(7);
            m_title = (GLabel)GetChildComAt(8);
            m_comp_logo = (UI_GuildLogoIconSkin)GetChildComAt(9);
            m_comp_activeValue = (UI_GuildActiveValueSkin)GetChildComAt(10);
            m_btn_manager = (GButton)GetChildComAt(11);
            m_btn_log = (GButton)GetChildComAt(12);
            m_exp = (GProgressBar)GetChildComAt(13);
            m_txt_title1 = (GTextField)GetChildAt(14);
            m_txt_guildName = (GTextField)GetChildAt(15);
            m_txt_id = (GRichTextField)GetChildAt(16);
            m_txt_count = (GTextField)GetChildAt(17);
            m_txt_title0 = (GTextField)GetChildAt(18);
            m_txt_notice = (GTextField)GetChildAt(19);
        }
    }
}