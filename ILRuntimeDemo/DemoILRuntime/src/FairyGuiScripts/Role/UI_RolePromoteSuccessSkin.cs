/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RolePromoteSuccessSkin : GComponent
    {
        public GLoader m_bg;
        public GComponent m_con_avatar;
        public GLabel m_title;
        public GImage m_img_headArrow;
        public GTextField m_txt_oldName;
        public GTextField m_txt_newName;
        public GComponent m_con_attr;
        public const string URL = "ui://edfpwlj6q5d42z";

        public static UI_RolePromoteSuccessSkin CreateInstance()
        {
            return (UI_RolePromoteSuccessSkin)UIPackage.CreateComponet("Role", "RolePromoteSuccessSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_con_avatar = (GComponent)GetChildComAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_img_headArrow = (GImage)GetChildAt(3);
            m_txt_oldName = (GTextField)GetChildAt(4);
            m_txt_newName = (GTextField)GetChildAt(5);
            m_con_attr = (GComponent)GetChildComAt(6);
        }
    }
}