/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_FriendMemberItemSkin : GComponent
    {
        public GImage m_n14;
        public GTextField m_txt_name;
        public GTextField m_txt_online;
        public GTextField m_txt_service;
        public GComponent m_comp_player;
        public GImage m_n20;
        public GImage m_n21;
        public GButton m_btn_delete;
        public GTextField m_txt_power;
        public GButton m_btn_give;
        public GButton m_btn_chat;
        public GButton m_btn_get;
        public GImage m_img_gave;
        public GImage m_img_got;
        public const string URL = "ui://jlg88jbimde4l";

        public static UI_FriendMemberItemSkin CreateInstance()
        {
            return (UI_FriendMemberItemSkin)UIPackage.CreateComponet("Friend", "FriendMemberItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n14 = (GImage)GetChildAt(0);
            m_txt_name = (GTextField)GetChildAt(1);
            m_txt_online = (GTextField)GetChildAt(2);
            m_txt_service = (GTextField)GetChildAt(3);
            m_comp_player = (GComponent)GetChildComAt(4);
            m_n20 = (GImage)GetChildAt(5);
            m_n21 = (GImage)GetChildAt(6);
            m_btn_delete = (GButton)GetChildComAt(7);
            m_txt_power = (GTextField)GetChildAt(8);
            m_btn_give = (GButton)GetChildComAt(9);
            m_btn_chat = (GButton)GetChildComAt(10);
            m_btn_get = (GButton)GetChildComAt(11);
            m_img_gave = (GImage)GetChildAt(12);
            m_img_got = (GImage)GetChildAt(13);
        }
    }
}