/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_FriendManagerSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public UI_ApplyCompSkin m_comp_apply;
        public UI_AddFriendCompSkin m_comp_addFriend;
        public UI_BlockCompSkin m_comp_block;
        public GButton m_tab_block;
        public GButton m_tab_add;
        public GButton m_tab_apply;
        public GLoader m_img_none;
        public GTextField m_txt_none;
        public GGroup m_n1;
        public const string URL = "ui://jlg88jbimde4n";

        public static UI_FriendManagerSkin CreateInstance()
        {
            return (UI_FriendManagerSkin)UIPackage.CreateComponet("Friend", "FriendManagerSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_comp_apply = (UI_ApplyCompSkin)GetChildComAt(1);
            m_comp_addFriend = (UI_AddFriendCompSkin)GetChildComAt(2);
            m_comp_block = (UI_BlockCompSkin)GetChildComAt(3);
            m_tab_block = (GButton)GetChildComAt(4);
            m_tab_add = (GButton)GetChildComAt(5);
            m_tab_apply = (GButton)GetChildComAt(6);
            m_img_none = (GLoader)GetChildAt(7);
            m_txt_none = (GTextField)GetChildAt(8);
            m_n1 = (GGroup)GetChildAt(9);
        }
    }
}