/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildOrderSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public GImage m_n14;
        public GImage m_n20;
        public GImage m_n13;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n4;
        public GImage m_n24;
        public GTextField m_txt_title0;
        public GTextField m_txt_title1;
        public GTextField m_txt_msg;
        public GTextField m_txt_orderCd;
        public GTextField m_txt_orderCount;
        public GButton m_btn_confirm;
        public GButton m_btn_reserve;
        public GButton m_btn_cancel;
        public GButton m_btn_over;
        public GList m_list_cost;
        public GList m_list_reward;
        public GList m_list_order;
        public GImage m_n30;
        public GImage m_n31;
        public GTextField m_txt_countCd;
        public GTextField m_txt_count;
        public GGroup m_group_count;
        public GImage m_img_bag;
        public const string URL = "ui://l0x7u1wbx7iau";

        public static UI_GuildOrderSkin CreateInstance()
        {
            return (UI_GuildOrderSkin)UIPackage.CreateComponet("GuildReward", "GuildOrderSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n14 = (GImage)GetChildAt(1);
            m_n20 = (GImage)GetChildAt(2);
            m_n13 = (GImage)GetChildAt(3);
            m_n1 = (GImage)GetChildAt(4);
            m_n2 = (GImage)GetChildAt(5);
            m_n3 = (GImage)GetChildAt(6);
            m_n4 = (GImage)GetChildAt(7);
            m_n24 = (GImage)GetChildAt(8);
            m_txt_title0 = (GTextField)GetChildAt(9);
            m_txt_title1 = (GTextField)GetChildAt(10);
            m_txt_msg = (GTextField)GetChildAt(11);
            m_txt_orderCd = (GTextField)GetChildAt(12);
            m_txt_orderCount = (GTextField)GetChildAt(13);
            m_btn_confirm = (GButton)GetChildComAt(14);
            m_btn_reserve = (GButton)GetChildComAt(15);
            m_btn_cancel = (GButton)GetChildComAt(16);
            m_btn_over = (GButton)GetChildComAt(17);
            m_list_cost = (GList)GetChildComAt(18);
            m_list_reward = (GList)GetChildComAt(19);
            m_list_order = (GList)GetChildComAt(20);
            m_n30 = (GImage)GetChildAt(21);
            m_n31 = (GImage)GetChildAt(22);
            m_txt_countCd = (GTextField)GetChildAt(23);
            m_txt_count = (GTextField)GetChildAt(24);
            m_group_count = (GGroup)GetChildAt(25);
            m_img_bag = (GImage)GetChildAt(26);
        }
    }
}