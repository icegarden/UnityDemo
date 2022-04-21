/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_FriendCompSkin : GComponent
    {
        public GImage m_n33;
        public GImage m_n34;
        public GImage m_n3;
        public GImage m_n4;
        public GTextField m_txt_friendship;
        public GTextField m_txt_member;
        public GList m_list_member;
        public GButton m_btn_onekey;
        public GButton m_btn_manager;
        public GButton m_btn_delete;
        public const string URL = "ui://jlg88jbimde4m";

        public static UI_FriendCompSkin CreateInstance()
        {
            return (UI_FriendCompSkin)UIPackage.CreateComponet("Friend", "FriendCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n33 = (GImage)GetChildAt(0);
            m_n34 = (GImage)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n4 = (GImage)GetChildAt(3);
            m_txt_friendship = (GTextField)GetChildAt(4);
            m_txt_member = (GTextField)GetChildAt(5);
            m_list_member = (GList)GetChildComAt(6);
            m_btn_onekey = (GButton)GetChildComAt(7);
            m_btn_manager = (GButton)GetChildComAt(8);
            m_btn_delete = (GButton)GetChildComAt(9);
        }
    }
}