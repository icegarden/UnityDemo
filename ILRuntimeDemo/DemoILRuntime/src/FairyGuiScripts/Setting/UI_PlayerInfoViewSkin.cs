/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_PlayerInfoViewSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n34;
        public GLoader m_img_head;
        public GImage m_n33;
        public GLoader m_img_slot;
        public GImage m_n3;
        public GImage m_n4;
        public GImage m_n5;
        public GImage m_n6;
        public GImage m_n7;
        public GImage m_bg_vip;
        public GImage m_n19;
        public GImage m_n20;
        public GImage m_n31;
        public GImage m_n30;
        public GTextField m_txt_power;
        public GTextField m_txt_vip;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_title;
        public GTextField m_txt_guild;
        public GTextField m_txt_server;
        public GTextField m_txt_account;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GButton m_btn_name;
        public GButton m_btn_guild;
        public GButton m_btn_copy;
        public GList m_list_squad;
        public GList m_list_record;
        public GButton m_btn_friend;
        public GButton m_btn_wait;
        public GButton m_btn_deleteFriend;
        public GButton m_btn_fight;
        public GButton m_btn_chat;
        public GButton m_btn_block;
        public GButton m_btn_cancelBlock;
        public GGroup m_n36;
        public const string URL = "ui://wi3k1s54fjwr1";

        public static UI_PlayerInfoViewSkin CreateInstance()
        {
            return (UI_PlayerInfoViewSkin)UIPackage.CreateComponet("Setting", "PlayerInfoViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n34 = (GImage)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_n33 = (GImage)GetChildAt(2);
            m_img_slot = (GLoader)GetChildAt(3);
            m_n3 = (GImage)GetChildAt(4);
            m_n4 = (GImage)GetChildAt(5);
            m_n5 = (GImage)GetChildAt(6);
            m_n6 = (GImage)GetChildAt(7);
            m_n7 = (GImage)GetChildAt(8);
            m_bg_vip = (GImage)GetChildAt(9);
            m_n19 = (GImage)GetChildAt(10);
            m_n20 = (GImage)GetChildAt(11);
            m_n31 = (GImage)GetChildAt(12);
            m_n30 = (GImage)GetChildAt(13);
            m_txt_power = (GTextField)GetChildAt(14);
            m_txt_vip = (GTextField)GetChildAt(15);
            m_txt_name = (GTextField)GetChildAt(16);
            m_txt_level = (GTextField)GetChildAt(17);
            m_txt_title = (GTextField)GetChildAt(18);
            m_txt_guild = (GTextField)GetChildAt(19);
            m_txt_server = (GTextField)GetChildAt(20);
            m_txt_account = (GTextField)GetChildAt(21);
            m_txt_tip1 = (GTextField)GetChildAt(22);
            m_txt_tip2 = (GTextField)GetChildAt(23);
            m_btn_name = (GButton)GetChildComAt(24);
            m_btn_guild = (GButton)GetChildComAt(25);
            m_btn_copy = (GButton)GetChildComAt(26);
            m_list_squad = (GList)GetChildComAt(27);
            m_list_record = (GList)GetChildComAt(28);
            m_btn_friend = (GButton)GetChildComAt(29);
            m_btn_wait = (GButton)GetChildComAt(30);
            m_btn_deleteFriend = (GButton)GetChildComAt(31);
            m_btn_fight = (GButton)GetChildComAt(32);
            m_btn_chat = (GButton)GetChildComAt(33);
            m_btn_block = (GButton)GetChildComAt(34);
            m_btn_cancelBlock = (GButton)GetChildComAt(35);
            m_n36 = (GGroup)GetChildAt(36);
        }
    }
}