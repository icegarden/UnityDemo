/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvolutionListSkin : GComponent
    {
        public Controller m_state;
        public Controller m_tab;
        public GLoader m_img_bg;
        public GLabel m_title;
        public GLoader m_img_bg1;
        public GLoader m_img_bg2;
        public GComponent m_con_avatar;
        public GLoader m_img_quality;
        public GImage m_n25;
        public GRichTextField m_txt_name;
        public GList m_list_star;
        public GLoader m_img_awake;
        public GGroup m_gp_top;
        public GImage m_n3;
        public GList m_list_select;
        public GList m_list_pet;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GButton m_btn_evolution;
        public GButton m_btn_smartEvo;
        public GButton m_btn_onekeyEvo;
        public const string URL = "ui://em095moes3fia9";

        public static UI_PetEvolutionListSkin CreateInstance()
        {
            return (UI_PetEvolutionListSkin)UIPackage.CreateComponet("Pet", "PetEvolutionListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_tab = GetControllerAt(1);
            m_img_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_img_bg1 = (GLoader)GetChildAt(2);
            m_img_bg2 = (GLoader)GetChildAt(3);
            m_con_avatar = (GComponent)GetChildComAt(4);
            m_img_quality = (GLoader)GetChildAt(5);
            m_n25 = (GImage)GetChildAt(6);
            m_txt_name = (GRichTextField)GetChildAt(7);
            m_list_star = (GList)GetChildComAt(8);
            m_img_awake = (GLoader)GetChildAt(9);
            m_gp_top = (GGroup)GetChildAt(10);
            m_n3 = (GImage)GetChildAt(11);
            m_list_select = (GList)GetChildComAt(12);
            m_list_pet = (GList)GetChildComAt(13);
            m_img_bottom = (GLoader)GetChildAt(14);
            m_btn_back = (GButton)GetChildComAt(15);
            m_btn_tab0 = (GButton)GetChildComAt(16);
            m_btn_tab1 = (GButton)GetChildComAt(17);
            m_btn_tab2 = (GButton)GetChildComAt(18);
            m_btn_tab3 = (GButton)GetChildComAt(19);
            m_btn_tab4 = (GButton)GetChildComAt(20);
            m_btn_tab5 = (GButton)GetChildComAt(21);
            m_btn_tab6 = (GButton)GetChildComAt(22);
            m_btn_evolution = (GButton)GetChildComAt(23);
            m_btn_smartEvo = (GButton)GetChildComAt(24);
            m_btn_onekeyEvo = (GButton)GetChildComAt(25);
        }
    }
}