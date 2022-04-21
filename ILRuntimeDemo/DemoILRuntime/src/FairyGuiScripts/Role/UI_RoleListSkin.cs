/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleListSkin : GComponent
    {
        public GLoader m_bg;
        public GImage m_n3;
        public GImage m_n4;
        public GTextField m_txt_power;
        public GTextField m_txt_name;
        public GTextField m_txt_type;
        public GComponent m_con_avatar;
        public GList m_list_head;
        public GList m_list_star;
        public const string URL = "ui://edfpwlj6dibi3i";

        public static UI_RoleListSkin CreateInstance()
        {
            return (UI_RoleListSkin)UIPackage.CreateComponet("Role", "RoleListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n4 = (GImage)GetChildAt(2);
            m_txt_power = (GTextField)GetChildAt(3);
            m_txt_name = (GTextField)GetChildAt(4);
            m_txt_type = (GTextField)GetChildAt(5);
            m_con_avatar = (GComponent)GetChildComAt(6);
            m_list_head = (GList)GetChildComAt(7);
            m_list_star = (GList)GetChildComAt(8);
        }
    }
}