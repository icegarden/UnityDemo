/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleGetSkin : GComponent
    {
        public GGraph m_bg;
        public GLoader m_img_icon;
        public GButton m_btn_skip;
        public const string URL = "ui://edfpwlj6dibi3q";

        public static UI_RoleGetSkin CreateInstance()
        {
            return (UI_RoleGetSkin)UIPackage.CreateComponet("Role", "RoleGetSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GGraph)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_btn_skip = (GButton)GetChildComAt(2);
        }
    }
}