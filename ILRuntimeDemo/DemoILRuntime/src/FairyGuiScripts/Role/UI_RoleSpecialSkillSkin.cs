/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleSpecialSkillSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public const string URL = "ui://edfpwlj6dibi3m";

        public static UI_RoleSpecialSkillSkin CreateInstance()
        {
            return (UI_RoleSpecialSkillSkin)UIPackage.CreateComponet("Role", "RoleSpecialSkillSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
        }
    }
}