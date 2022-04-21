/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardNpcSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n29;
        public GButton m_btn_start;
        public GComponent m_item_cost;
        public GTextField m_txt_cost;
        public GTextField m_txt_name;
        public GList m_list_npc;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_detail;
        public GComponent m_comp_player;
        public GImage m_n15;
        public GProgressBar m_exp;
        public GList m_list_pro;
        public UI_GuildRewardNpcItem3Skin m_item_time;
        public UI_GuildRewardNpcItem3Skin m_item_num;
        public UI_GuildRewardNpcItem3Skin m_item_intimacy;
        public const string URL = "ui://l0x7u1wbo1uck";

        public static UI_GuildRewardNpcSkin CreateInstance()
        {
            return (UI_GuildRewardNpcSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardNpcSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n29 = (GImage)GetChildAt(1);
            m_btn_start = (GButton)GetChildComAt(2);
            m_item_cost = (GComponent)GetChildComAt(3);
            m_txt_cost = (GTextField)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_list_npc = (GList)GetChildComAt(6);
            m_btn_left = (GButton)GetChildComAt(7);
            m_btn_right = (GButton)GetChildComAt(8);
            m_btn_detail = (GButton)GetChildComAt(9);
            m_comp_player = (GComponent)GetChildComAt(10);
            m_n15 = (GImage)GetChildAt(11);
            m_exp = (GProgressBar)GetChildComAt(12);
            m_list_pro = (GList)GetChildComAt(13);
            m_item_time = (UI_GuildRewardNpcItem3Skin)GetChildComAt(14);
            m_item_num = (UI_GuildRewardNpcItem3Skin)GetChildComAt(15);
            m_item_intimacy = (UI_GuildRewardNpcItem3Skin)GetChildComAt(16);
        }
    }
}