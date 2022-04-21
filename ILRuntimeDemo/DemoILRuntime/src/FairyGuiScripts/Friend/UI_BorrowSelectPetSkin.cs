/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BorrowSelectPetSkin : GComponent
    {
        public Controller m_c1;
        public GLabel m_bg;
        public GImage m_n1;
        public GImage m_n2;
        public GList m_list_pet;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n13;
        public const string URL = "ui://jlg88jbimr001e";

        public static UI_BorrowSelectPetSkin CreateInstance()
        {
            return (UI_BorrowSelectPetSkin)UIPackage.CreateComponet("Friend", "BorrowSelectPetSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_c1 = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_list_pet = (GList)GetChildComAt(3);
            m_btn_tab0 = (GButton)GetChildComAt(4);
            m_btn_tab1 = (GButton)GetChildComAt(5);
            m_btn_tab2 = (GButton)GetChildComAt(6);
            m_btn_tab3 = (GButton)GetChildComAt(7);
            m_btn_tab4 = (GButton)GetChildComAt(8);
            m_btn_tab5 = (GButton)GetChildComAt(9);
            m_btn_tab6 = (GButton)GetChildComAt(10);
            m_btn_confirm = (GButton)GetChildComAt(11);
            m_btn_cancel = (GButton)GetChildComAt(12);
            m_n13 = (GGroup)GetChildAt(13);
        }
    }
}