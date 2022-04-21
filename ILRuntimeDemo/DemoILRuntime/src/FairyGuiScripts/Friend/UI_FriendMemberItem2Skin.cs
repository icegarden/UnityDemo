/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_FriendMemberItem2Skin : GComponent
    {
        public Controller m_control;
        public GImage m_n14;
        public GTextField m_txt_name;
        public GTextField m_txt_online;
        public GTextField m_txt_service;
        public GTextField m_txt_wait;
        public GComponent m_comp_player;
        public GImage m_n20;
        public GImage m_n21;
        public GButton m_btn_deleteApply;
        public GButton m_btn_deleteBlock;
        public GTextField m_txt_power;
        public GButton m_btn_agree;
        public GButton m_btn_add;
        public const string URL = "ui://jlg88jbimde4o";

        public static UI_FriendMemberItem2Skin CreateInstance()
        {
            return (UI_FriendMemberItem2Skin)UIPackage.CreateComponet("Friend", "FriendMemberItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_n14 = (GImage)GetChildAt(0);
            m_txt_name = (GTextField)GetChildAt(1);
            m_txt_online = (GTextField)GetChildAt(2);
            m_txt_service = (GTextField)GetChildAt(3);
            m_txt_wait = (GTextField)GetChildAt(4);
            m_comp_player = (GComponent)GetChildComAt(5);
            m_n20 = (GImage)GetChildAt(6);
            m_n21 = (GImage)GetChildAt(7);
            m_btn_deleteApply = (GButton)GetChildComAt(8);
            m_btn_deleteBlock = (GButton)GetChildComAt(9);
            m_txt_power = (GTextField)GetChildAt(10);
            m_btn_agree = (GButton)GetChildComAt(11);
            m_btn_add = (GButton)GetChildComAt(12);
        }
    }
}