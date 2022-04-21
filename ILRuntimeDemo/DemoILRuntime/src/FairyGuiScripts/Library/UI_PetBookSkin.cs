/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Library
{
    public partial class UI_PetBookSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GLabel m_title;
        public GComponent m_n37;
        public GImage m_n38;
        public GComponent m_n33;
        public GComponent m_n3;
        public GLoader m_shading;
        public GImage m_n26;
        public GImage m_n27;
        public GImage m_n7;
        public GImage m_n4;
        public GTextField m_txt_tip;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_effect;
        public GTextField m_txt_full;
        public GList m_list_pet;
        public GButton m_btn_back;
        public GProgressBar m_pb_exp;
        public GList m_list_attr;
        public GGraph m_n30;
        public GGraph m_n35;
        public GGraph m_n36;
        public GTextField m_txt_rewardLevel;
        public GList m_list_reward;
        public GButton m_btn_take;
        public GGroup m_gp_reward;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GGroup m_gp_tab;
        public const string URL = "ui://vkxqgoc5ycl70";

        public static UI_PetBookSkin CreateInstance()
        {
            return (UI_PetBookSkin)UIPackage.CreateComponet("Library", "PetBookSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_n37 = (GComponent)GetChildComAt(2);
            m_n38 = (GImage)GetChildAt(3);
            m_n33 = (GComponent)GetChildComAt(4);
            m_n3 = (GComponent)GetChildComAt(5);
            m_shading = (GLoader)GetChildAt(6);
            m_n26 = (GImage)GetChildAt(7);
            m_n27 = (GImage)GetChildAt(8);
            m_n7 = (GImage)GetChildAt(9);
            m_n4 = (GImage)GetChildAt(10);
            m_txt_tip = (GTextField)GetChildAt(11);
            m_txt_name = (GTextField)GetChildAt(12);
            m_txt_level = (GTextField)GetChildAt(13);
            m_txt_effect = (GTextField)GetChildAt(14);
            m_txt_full = (GTextField)GetChildAt(15);
            m_list_pet = (GList)GetChildComAt(16);
            m_btn_back = (GButton)GetChildComAt(17);
            m_pb_exp = (GProgressBar)GetChildComAt(18);
            m_list_attr = (GList)GetChildComAt(19);
            m_n30 = (GGraph)GetChildAt(20);
            m_n35 = (GGraph)GetChildAt(21);
            m_n36 = (GGraph)GetChildAt(22);
            m_txt_rewardLevel = (GTextField)GetChildAt(23);
            m_list_reward = (GList)GetChildComAt(24);
            m_btn_take = (GButton)GetChildComAt(25);
            m_gp_reward = (GGroup)GetChildAt(26);
            m_btn_tab1 = (GButton)GetChildComAt(27);
            m_btn_tab2 = (GButton)GetChildComAt(28);
            m_btn_tab3 = (GButton)GetChildComAt(29);
            m_btn_tab4 = (GButton)GetChildComAt(30);
            m_btn_tab5 = (GButton)GetChildComAt(31);
            m_gp_tab = (GGroup)GetChildAt(32);
        }
    }
}