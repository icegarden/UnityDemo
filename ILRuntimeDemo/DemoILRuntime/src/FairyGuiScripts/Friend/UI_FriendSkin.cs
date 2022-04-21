/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_FriendSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public UI_FriendCompSkin m_comp_friend;
        public UI_BorrowCompSkin m_comp_borrow;
        public GLoader m_img_none;
        public GTextField m_txt_none;
        public GButton m_tab_borrow;
        public GButton m_tab_friend;
        public const string URL = "ui://jlg88jbimde40";

        public static UI_FriendSkin CreateInstance()
        {
            return (UI_FriendSkin)UIPackage.CreateComponet("Friend", "FriendSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_comp_friend = (UI_FriendCompSkin)GetChildComAt(1);
            m_comp_borrow = (UI_BorrowCompSkin)GetChildComAt(2);
            m_img_none = (GLoader)GetChildAt(3);
            m_txt_none = (GTextField)GetChildAt(4);
            m_tab_borrow = (GButton)GetChildComAt(5);
            m_tab_friend = (GButton)GetChildComAt(6);
        }
    }
}