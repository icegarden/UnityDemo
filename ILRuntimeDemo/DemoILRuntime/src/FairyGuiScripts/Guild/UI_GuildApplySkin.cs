/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildApplySkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n3;
        public GImage m_n20;
        public GImage m_n14;
        public GImage m_n15;
        public GTextField m_txt_title0;
        public GTextField m_txt_joinNotice;
        public GTextField m_txt_title1;
        public GTextField m_txt_title2;
        public GTextField m_txt_limitLevel;
        public GTextField m_txt_limltType;
        public GTextField m_txt_guildName;
        public GRichTextField m_txt_id;
        public UI_GuildLogoIconSkin m_comp_logo;
        public UI_GuildActiveValueSkin m_comp_activeValue;
        public GButton m_btn_join;
        public GGroup m_n23;
        public const string URL = "ui://tae9x4e9yfna13";

        public static UI_GuildApplySkin CreateInstance()
        {
            return (UI_GuildApplySkin)UIPackage.CreateComponet("Guild", "GuildApplySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n20 = (GImage)GetChildAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_n15 = (GImage)GetChildAt(4);
            m_txt_title0 = (GTextField)GetChildAt(5);
            m_txt_joinNotice = (GTextField)GetChildAt(6);
            m_txt_title1 = (GTextField)GetChildAt(7);
            m_txt_title2 = (GTextField)GetChildAt(8);
            m_txt_limitLevel = (GTextField)GetChildAt(9);
            m_txt_limltType = (GTextField)GetChildAt(10);
            m_txt_guildName = (GTextField)GetChildAt(11);
            m_txt_id = (GRichTextField)GetChildAt(12);
            m_comp_logo = (UI_GuildLogoIconSkin)GetChildComAt(13);
            m_comp_activeValue = (UI_GuildActiveValueSkin)GetChildComAt(14);
            m_btn_join = (GButton)GetChildComAt(15);
            m_n23 = (GGroup)GetChildAt(16);
        }
    }
}