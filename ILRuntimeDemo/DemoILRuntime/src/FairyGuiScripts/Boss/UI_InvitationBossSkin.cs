/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_InvitationBossSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_bottom;
        public GImage m_n16;
        public GComponent m_con_avatar;
        public GLabel m_title;
        public GTextField m_txt_time;
        public GTextField m_txt_level;
        public GButton m_btn_task;
        public GButton m_btn_back;
        public GButton m_btn_tip;
        public GLoader m_img_center;
        public GImage m_n11;
        public GImage m_n12;
        public GImage m_n23;
        public GImage m_n24;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_damge;
        public GList m_list_skill;
        public GList m_list_element;
        public GButton m_btn_challenge;
        public GGroup m_gp_bottom;
        public const string URL = "ui://etkvbnyek73kt";

        public static UI_InvitationBossSkin CreateInstance()
        {
            return (UI_InvitationBossSkin)UIPackage.CreateComponet("Boss", "InvitationBossSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_n16 = (GImage)GetChildAt(2);
            m_con_avatar = (GComponent)GetChildComAt(3);
            m_title = (GLabel)GetChildComAt(4);
            m_txt_time = (GTextField)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_btn_task = (GButton)GetChildComAt(7);
            m_btn_back = (GButton)GetChildComAt(8);
            m_btn_tip = (GButton)GetChildComAt(9);
            m_img_center = (GLoader)GetChildAt(10);
            m_n11 = (GImage)GetChildAt(11);
            m_n12 = (GImage)GetChildAt(12);
            m_n23 = (GImage)GetChildAt(13);
            m_n24 = (GImage)GetChildAt(14);
            m_txt_tip1 = (GTextField)GetChildAt(15);
            m_txt_tip2 = (GTextField)GetChildAt(16);
            m_txt_damge = (GTextField)GetChildAt(17);
            m_list_skill = (GList)GetChildComAt(18);
            m_list_element = (GList)GetChildComAt(19);
            m_btn_challenge = (GButton)GetChildComAt(20);
            m_gp_bottom = (GGroup)GetChildAt(21);
        }
    }
}