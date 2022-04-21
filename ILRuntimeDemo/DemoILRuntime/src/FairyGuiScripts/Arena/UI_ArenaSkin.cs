/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_img_top;
        public GImage m_n38;
        public GImage m_n41;
        public UI_PlayerHead2Skin m_item_head;
        public GLoader m_img_level;
        public GRichTextField m_txt_time;
        public GTextField m_txt_name;
        public GRichTextField m_txt_score;
        public GTextField m_txt_tip;
        public GButton m_btn_reward;
        public GButton m_btn_defense;
        public GButton m_btn_rank;
        public GButton m_btn_record;
        public GGroup m_gp_top;
        public GLoader m_img_listBg1;
        public GLoader m_img_listBg2;
        public GComponent m_item_ticket;
        public GRichTextField m_txt_refresh;
        public GButton m_btn_refresh;
        public GGroup m_gp_bottom;
        public GLabel m_txt_title;
        public GList m_list_item;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public const string URL = "ui://m8qegzmncnj34";

        public static UI_ArenaSkin CreateInstance()
        {
            return (UI_ArenaSkin)UIPackage.CreateComponet("Arena", "ArenaSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_n38 = (GImage)GetChildAt(2);
            m_n41 = (GImage)GetChildAt(3);
            m_item_head = (UI_PlayerHead2Skin)GetChildComAt(4);
            m_img_level = (GLoader)GetChildAt(5);
            m_txt_time = (GRichTextField)GetChildAt(6);
            m_txt_name = (GTextField)GetChildAt(7);
            m_txt_score = (GRichTextField)GetChildAt(8);
            m_txt_tip = (GTextField)GetChildAt(9);
            m_btn_reward = (GButton)GetChildComAt(10);
            m_btn_defense = (GButton)GetChildComAt(11);
            m_btn_rank = (GButton)GetChildComAt(12);
            m_btn_record = (GButton)GetChildComAt(13);
            m_gp_top = (GGroup)GetChildAt(14);
            m_img_listBg1 = (GLoader)GetChildAt(15);
            m_img_listBg2 = (GLoader)GetChildAt(16);
            m_item_ticket = (GComponent)GetChildComAt(17);
            m_txt_refresh = (GRichTextField)GetChildAt(18);
            m_btn_refresh = (GButton)GetChildComAt(19);
            m_gp_bottom = (GGroup)GetChildAt(20);
            m_txt_title = (GLabel)GetChildComAt(21);
            m_list_item = (GList)GetChildComAt(22);
            m_img_bottom = (GLoader)GetChildAt(23);
            m_btn_back = (GButton)GetChildComAt(24);
        }
    }
}