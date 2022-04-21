/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetRebornSkin : GComponent
    {
        public Controller m_tab_element;
        public Controller m_state;
        public Controller m_tab_page;
        public GLoader m_img_bg;
        public GLabel m_title;
        public GLoader m_img_bg1;
        public GLoader m_img_bg2;
        public GImage m_n57;
        public GImage m_n42;
        public GImage m_n53;
        public GComponent m_item_pet;
        public GList m_list_return;
        public GTextField m_txt_tip;
        public GRichTextField m_txt_leftCount;
        public GTextField m_txt_petCount;
        public UI_CostButtonSkin m_btn_reborn;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GList m_list_pet;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GButton m_tab_reborn;
        public GButton m_tab_reset;
        public GButton m_btn_help;
        public const string URL = "ui://em095moert0bo";

        public static UI_PetRebornSkin CreateInstance()
        {
            return (UI_PetRebornSkin)UIPackage.CreateComponet("Pet", "PetRebornSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab_element = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_tab_page = GetControllerAt(2);
            m_img_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_img_bg1 = (GLoader)GetChildAt(2);
            m_img_bg2 = (GLoader)GetChildAt(3);
            m_n57 = (GImage)GetChildAt(4);
            m_n42 = (GImage)GetChildAt(5);
            m_n53 = (GImage)GetChildAt(6);
            m_item_pet = (GComponent)GetChildComAt(7);
            m_list_return = (GList)GetChildComAt(8);
            m_txt_tip = (GTextField)GetChildAt(9);
            m_txt_leftCount = (GRichTextField)GetChildAt(10);
            m_txt_petCount = (GTextField)GetChildAt(11);
            m_btn_reborn = (UI_CostButtonSkin)GetChildComAt(12);
            m_btn_tab0 = (GButton)GetChildComAt(13);
            m_btn_tab1 = (GButton)GetChildComAt(14);
            m_btn_tab2 = (GButton)GetChildComAt(15);
            m_btn_tab3 = (GButton)GetChildComAt(16);
            m_btn_tab4 = (GButton)GetChildComAt(17);
            m_btn_tab5 = (GButton)GetChildComAt(18);
            m_btn_tab6 = (GButton)GetChildComAt(19);
            m_list_pet = (GList)GetChildComAt(20);
            m_img_bottom = (GLoader)GetChildAt(21);
            m_btn_back = (GButton)GetChildComAt(22);
            m_tab_reborn = (GButton)GetChildComAt(23);
            m_tab_reset = (GButton)GetChildComAt(24);
            m_btn_help = (GButton)GetChildComAt(25);
        }
    }
}