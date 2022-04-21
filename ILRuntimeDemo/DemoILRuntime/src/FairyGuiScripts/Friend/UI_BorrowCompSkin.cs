/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BorrowCompSkin : GComponent
    {
        public Controller m_control;
        public GLoader m_img_bg;
        public GImage m_n48;
        public GImage m_n49;
        public GImage m_n44;
        public GList m_list_pet;
        public GList m_list_borrow;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GButton m_btn_manager;
        public GButton m_btn_tip;
        public GTextField m_txt0;
        public GTextField m_txt1;
        public const string URL = "ui://jlg88jbimr0012";

        public static UI_BorrowCompSkin CreateInstance()
        {
            return (UI_BorrowCompSkin)UIPackage.CreateComponet("Friend", "BorrowCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_n48 = (GImage)GetChildAt(1);
            m_n49 = (GImage)GetChildAt(2);
            m_n44 = (GImage)GetChildAt(3);
            m_list_pet = (GList)GetChildComAt(4);
            m_list_borrow = (GList)GetChildComAt(5);
            m_btn_tab0 = (GButton)GetChildComAt(6);
            m_btn_tab1 = (GButton)GetChildComAt(7);
            m_btn_tab2 = (GButton)GetChildComAt(8);
            m_btn_tab3 = (GButton)GetChildComAt(9);
            m_btn_tab4 = (GButton)GetChildComAt(10);
            m_btn_tab5 = (GButton)GetChildComAt(11);
            m_btn_tab6 = (GButton)GetChildComAt(12);
            m_btn_manager = (GButton)GetChildComAt(13);
            m_btn_tip = (GButton)GetChildComAt(14);
            m_txt0 = (GTextField)GetChildAt(15);
            m_txt1 = (GTextField)GetChildAt(16);
        }
    }
}