/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetBagSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GList m_list_item;
        public GLoader m_img_bottombg;
        public GComponent m_item_decompose;
        public GButton m_btn_dispose;
        public GGroup m_pet_bottom;
        public GImage m_n39;
        public GImage m_n31;
        public GTextField m_txt_petCount;
        public GButton m_btn_addBagCount;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GGroup m_pet_top;
        public const string URL = "ui://em095moepcju0";

        public static UI_PetBagSkin CreateInstance()
        {
            return (UI_PetBagSkin)UIPackage.CreateComponet("Pet", "PetBagSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_img_bottombg = (GLoader)GetChildAt(2);
            m_item_decompose = (GComponent)GetChildComAt(3);
            m_btn_dispose = (GButton)GetChildComAt(4);
            m_pet_bottom = (GGroup)GetChildAt(5);
            m_n39 = (GImage)GetChildAt(6);
            m_n31 = (GImage)GetChildAt(7);
            m_txt_petCount = (GTextField)GetChildAt(8);
            m_btn_addBagCount = (GButton)GetChildComAt(9);
            m_btn_tab0 = (GButton)GetChildComAt(10);
            m_btn_tab1 = (GButton)GetChildComAt(11);
            m_btn_tab2 = (GButton)GetChildComAt(12);
            m_btn_tab3 = (GButton)GetChildComAt(13);
            m_btn_tab4 = (GButton)GetChildComAt(14);
            m_btn_tab5 = (GButton)GetChildComAt(15);
            m_btn_tab6 = (GButton)GetChildComAt(16);
            m_pet_top = (GGroup)GetChildAt(17);
        }
    }
}