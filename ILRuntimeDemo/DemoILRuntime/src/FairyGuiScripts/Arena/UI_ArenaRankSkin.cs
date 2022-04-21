/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRankSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GLoader m_img_bg1;
        public GButton m_btn_current;
        public GButton m_btn_top;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n48;
        public GTextField m_txt_title;
        public GList m_list_item;
        public GImage m_n31;
        public GImage m_n32;
        public GImage m_n33;
        public UI_PlayerHead1Skin m_item_head;
        public GLoader m_img_level;
        public GTextField m_txt_rank;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_score;
        public GGroup m_gp_myRank;
        public GButton m_btn_back;
        public const string URL = "ui://m8qegzmncnj38";

        public static UI_ArenaRankSkin CreateInstance()
        {
            return (UI_ArenaRankSkin)UIPackage.CreateComponet("Arena", "ArenaRankSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_btn_current = (GButton)GetChildComAt(2);
            m_btn_top = (GButton)GetChildComAt(3);
            m_img_bg2 = (GLoader)GetChildAt(4);
            m_img_top = (GLoader)GetChildAt(5);
            m_n48 = (GImage)GetChildAt(6);
            m_txt_title = (GTextField)GetChildAt(7);
            m_list_item = (GList)GetChildComAt(8);
            m_n31 = (GImage)GetChildAt(9);
            m_n32 = (GImage)GetChildAt(10);
            m_n33 = (GImage)GetChildAt(11);
            m_item_head = (UI_PlayerHead1Skin)GetChildComAt(12);
            m_img_level = (GLoader)GetChildAt(13);
            m_txt_rank = (GTextField)GetChildAt(14);
            m_txt_name = (GRichTextField)GetChildAt(15);
            m_txt_score = (GRichTextField)GetChildAt(16);
            m_gp_myRank = (GGroup)GetChildAt(17);
            m_btn_back = (GButton)GetChildComAt(18);
        }
    }
}