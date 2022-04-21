/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleSpecialItemSkin : GComponent
    {
        public GImage m_bg;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GList m_list_star;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://edfpwlj6dibi3n";

        public static UI_RoleSpecialItemSkin CreateInstance()
        {
            return (UI_RoleSpecialItemSkin)UIPackage.CreateComponet("Role", "RoleSpecialItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_img_slot = (GLoader)GetChildAt(3);
            m_list_star = (GList)GetChildComAt(4);
            m_txt_desc = (GRichTextField)GetChildAt(5);
        }
    }
}