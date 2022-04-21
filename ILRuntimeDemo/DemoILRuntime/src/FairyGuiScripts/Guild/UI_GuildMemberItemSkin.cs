/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildMemberItemSkin : GComponent
    {
        public GImage m_n1;
        public GGraph m_hit;
        public GTextField m_txt_name;
        public GTextField m_txt_online;
        public GTextField m_txt_service;
        public GComponent m_comp_player;
        public UI_GuildActiveValueSkin m_comp_activeValue;
        public GLoader m_img_position;
        public const string URL = "ui://tae9x4e9yfnak";

        public static UI_GuildMemberItemSkin CreateInstance()
        {
            return (UI_GuildMemberItemSkin)UIPackage.CreateComponet("Guild", "GuildMemberItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_hit = (GGraph)GetChildAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_txt_online = (GTextField)GetChildAt(3);
            m_txt_service = (GTextField)GetChildAt(4);
            m_comp_player = (GComponent)GetChildComAt(5);
            m_comp_activeValue = (UI_GuildActiveValueSkin)GetChildComAt(6);
            m_img_position = (GLoader)GetChildAt(7);
        }
    }
}