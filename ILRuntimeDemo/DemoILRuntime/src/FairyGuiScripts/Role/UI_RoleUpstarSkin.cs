/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleUpstarSkin : GComponent
    {
        public GLabel m_n0;
        public GImage m_n1;
        public GLoader m_img_head;
        public GImage m_n3;
        public GProgressBar m_pb_chip;
        public GImage m_n19;
        public GImage m_img_chip;
        public GList m_list_attr;
        public GTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_effectTitle;
        public GTextField m_txt_effect;
        public GButton m_btn_add;
        public GButton m_btn_upstar;
        public GButton m_btn_chip;
        public GList m_list_curStar;
        public GList m_list_nextStar;
        public GList m_list_star;
        public GComponent m_con_avatar;
        public GGroup m_n33;
        public const string URL = "ui://edfpwlj6dibi3o";

        public static UI_RoleUpstarSkin CreateInstance()
        {
            return (UI_RoleUpstarSkin)UIPackage.CreateComponet("Role", "RoleUpstarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_img_head = (GLoader)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_pb_chip = (GProgressBar)GetChildComAt(4);
            m_n19 = (GImage)GetChildAt(5);
            m_img_chip = (GImage)GetChildAt(6);
            m_list_attr = (GList)GetChildComAt(7);
            m_txt_name = (GTextField)GetChildAt(8);
            m_txt_type = (GTextField)GetChildAt(9);
            m_txt_effectTitle = (GTextField)GetChildAt(10);
            m_txt_effect = (GTextField)GetChildAt(11);
            m_btn_add = (GButton)GetChildComAt(12);
            m_btn_upstar = (GButton)GetChildComAt(13);
            m_btn_chip = (GButton)GetChildComAt(14);
            m_list_curStar = (GList)GetChildComAt(15);
            m_list_nextStar = (GList)GetChildComAt(16);
            m_list_star = (GList)GetChildComAt(17);
            m_con_avatar = (GComponent)GetChildComAt(18);
            m_n33 = (GGroup)GetChildAt(19);
        }
    }
}