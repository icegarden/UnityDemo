/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildOrderItemSkin : GButton
    {
        public Controller m_control;
        public Controller m_button;
        public GImage m_n16;
        public GComponent m_item;
        public GTextField m_txt_name;
        public GImage m_n17;
        public GImage m_n23;
        public GImage m_n18;
        public GImage m_n19;
        public GList m_list_cost;
        public const string URL = "ui://l0x7u1wbx7iaw";

        public static UI_GuildOrderItemSkin CreateInstance()
        {
            return (UI_GuildOrderItemSkin)UIPackage.CreateComponet("GuildReward", "GuildOrderItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_button = GetControllerAt(1);
            m_n16 = (GImage)GetChildAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_n17 = (GImage)GetChildAt(3);
            m_n23 = (GImage)GetChildAt(4);
            m_n18 = (GImage)GetChildAt(5);
            m_n19 = (GImage)GetChildAt(6);
            m_list_cost = (GList)GetChildComAt(7);
        }
    }
}