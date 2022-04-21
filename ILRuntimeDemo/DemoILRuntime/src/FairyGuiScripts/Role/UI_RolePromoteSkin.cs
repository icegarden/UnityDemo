/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RolePromoteSkin : GComponent
    {
        public GLoader m_bg;
        public GComponent m_n2;
        public GImage m_n21;
        public GImage m_n8;
        public GImage m_n3;
        public GImage m_n13;
        public GImage m_n17;
        public GTextField m_tip1;
        public GTextField m_tip2;
        public GRichTextField m_txt_name;
        public GComponent m_con_avatar;
        public GList m_list_reward;
        public GList m_list_condition;
        public GButton m_btn_promote;
        public GButton m_btn_back;
        public const string URL = "ui://edfpwlj6q5d42v";

        public static UI_RolePromoteSkin CreateInstance()
        {
            return (UI_RolePromoteSkin)UIPackage.CreateComponet("Role", "RolePromoteSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_n2 = (GComponent)GetChildComAt(1);
            m_n21 = (GImage)GetChildAt(2);
            m_n8 = (GImage)GetChildAt(3);
            m_n3 = (GImage)GetChildAt(4);
            m_n13 = (GImage)GetChildAt(5);
            m_n17 = (GImage)GetChildAt(6);
            m_tip1 = (GTextField)GetChildAt(7);
            m_tip2 = (GTextField)GetChildAt(8);
            m_txt_name = (GRichTextField)GetChildAt(9);
            m_con_avatar = (GComponent)GetChildComAt(10);
            m_list_reward = (GList)GetChildComAt(11);
            m_list_condition = (GList)GetChildComAt(12);
            m_btn_promote = (GButton)GetChildComAt(13);
            m_btn_back = (GButton)GetChildComAt(14);
        }
    }
}