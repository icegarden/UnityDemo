/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardNpcItem2Skin : GComponent
    {
        public GComponent m_comp_player;
        public GImage m_n8;
        public GTextField m_txt_love;
        public GTextField m_txt_name;
        public UI_GuildCostSkin m_item_cost;
        public const string URL = "ui://l0x7u1wbo1ucm";

        public static UI_GuildRewardNpcItem2Skin CreateInstance()
        {
            return (UI_GuildRewardNpcItem2Skin)UIPackage.CreateComponet("GuildReward", "GuildRewardNpcItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_comp_player = (GComponent)GetChildComAt(0);
            m_n8 = (GImage)GetChildAt(1);
            m_txt_love = (GTextField)GetChildAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
            m_item_cost = (UI_GuildCostSkin)GetChildComAt(4);
        }
    }
}