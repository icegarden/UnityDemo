/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildApplyItemSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n15;
        public GImage m_n16;
        public GTextField m_txt_power;
        public GTextField m_txt_name;
        public GTextField m_txt_online;
        public GTextField m_txt_service;
        public GComponent m_comp_player;
        public GButton m_btn_ignore;
        public GButton m_btn_agree;
        public const string URL = "ui://tae9x4e9yfna1c";

        public static UI_GuildApplyItemSkin CreateInstance()
        {
            return (UI_GuildApplyItemSkin)UIPackage.CreateComponet("Guild", "GuildApplyItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n15 = (GImage)GetChildAt(1);
            m_n16 = (GImage)GetChildAt(2);
            m_txt_power = (GTextField)GetChildAt(3);
            m_txt_name = (GTextField)GetChildAt(4);
            m_txt_online = (GTextField)GetChildAt(5);
            m_txt_service = (GTextField)GetChildAt(6);
            m_comp_player = (GComponent)GetChildComAt(7);
            m_btn_ignore = (GButton)GetChildComAt(8);
            m_btn_agree = (GButton)GetChildComAt(9);
        }
    }
}