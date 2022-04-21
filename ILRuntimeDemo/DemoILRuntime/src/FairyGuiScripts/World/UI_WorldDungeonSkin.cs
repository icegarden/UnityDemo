/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldDungeonSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n16;
        public GLoader m_img_icon;
        public GImage m_n15;
        public GImage m_n18;
        public GImage m_n19;
        public GImage m_n21;
        public GImage m_n22;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_time;
        public GRichTextField m_txt_level;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_myRank;
        public GTextField m_txt_rank;
        public GList m_list_rank;
        public GList m_list_reward;
        public GButton m_btn_tip;
        public GButton m_btn_challenge;
        public GButton m_btn_ignore;
        public const string URL = "ui://63ubk2jodibio";

        public static UI_WorldDungeonSkin CreateInstance()
        {
            return (UI_WorldDungeonSkin)UIPackage.CreateComponet("World", "WorldDungeonSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n16 = (GImage)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n15 = (GImage)GetChildAt(3);
            m_n18 = (GImage)GetChildAt(4);
            m_n19 = (GImage)GetChildAt(5);
            m_n21 = (GImage)GetChildAt(6);
            m_n22 = (GImage)GetChildAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
            m_txt_time = (GRichTextField)GetChildAt(9);
            m_txt_level = (GRichTextField)GetChildAt(10);
            m_txt_tip1 = (GTextField)GetChildAt(11);
            m_txt_tip2 = (GTextField)GetChildAt(12);
            m_txt_myRank = (GTextField)GetChildAt(13);
            m_txt_rank = (GTextField)GetChildAt(14);
            m_list_rank = (GList)GetChildComAt(15);
            m_list_reward = (GList)GetChildComAt(16);
            m_btn_tip = (GButton)GetChildComAt(17);
            m_btn_challenge = (GButton)GetChildComAt(18);
            m_btn_ignore = (GButton)GetChildComAt(19);
        }
    }
}