/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BorrowManagerSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public GList m_list_apply;
        public GList m_list_borrow;
        public GImage m_n19;
        public GImage m_n20;
        public GTextField m_txt_friendship;
        public GTextField m_txt0;
        public GLoader m_img_none;
        public GTextField m_txt_none;
        public GButton m_tab_apply;
        public GButton m_tab_borrow;
        public const string URL = "ui://jlg88jbimr0019";

        public static UI_BorrowManagerSkin CreateInstance()
        {
            return (UI_BorrowManagerSkin)UIPackage.CreateComponet("Friend", "BorrowManagerSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_list_apply = (GList)GetChildComAt(1);
            m_list_borrow = (GList)GetChildComAt(2);
            m_n19 = (GImage)GetChildAt(3);
            m_n20 = (GImage)GetChildAt(4);
            m_txt_friendship = (GTextField)GetChildAt(5);
            m_txt0 = (GTextField)GetChildAt(6);
            m_img_none = (GLoader)GetChildAt(7);
            m_txt_none = (GTextField)GetChildAt(8);
            m_tab_apply = (GButton)GetChildComAt(9);
            m_tab_borrow = (GButton)GetChildComAt(10);
        }
    }
}