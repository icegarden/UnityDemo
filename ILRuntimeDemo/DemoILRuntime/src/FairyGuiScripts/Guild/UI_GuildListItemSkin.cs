/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildListItemSkin : GComponent
    {
        public Controller m_control;
        public GImage m_n14;
        public UI_GuildLogoIconSkin m_comp_logo;
        public UI_GuildActiveValueSkin m_comp_activeValue;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_count;
        public GImage m_n24;
        public GImage m_n23;
        public GTextField m_txt0;
        public const string URL = "ui://tae9x4e9yfnaf";

        public static UI_GuildListItemSkin CreateInstance()
        {
            return (UI_GuildListItemSkin)UIPackage.CreateComponet("Guild", "GuildListItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_n14 = (GImage)GetChildAt(0);
            m_comp_logo = (UI_GuildLogoIconSkin)GetChildComAt(1);
            m_comp_activeValue = (UI_GuildActiveValueSkin)GetChildComAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
            m_n24 = (GImage)GetChildAt(6);
            m_n23 = (GImage)GetChildAt(7);
            m_txt0 = (GTextField)GetChildAt(8);
        }
    }
}