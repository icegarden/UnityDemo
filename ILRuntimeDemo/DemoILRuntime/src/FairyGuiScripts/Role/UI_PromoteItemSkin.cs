/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_PromoteItemSkin : GComponent
    {
        public GImage m_n1;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_count;
        public const string URL = "ui://edfpwlj6q5d42w";

        public static UI_PromoteItemSkin CreateInstance()
        {
            return (UI_PromoteItemSkin)UIPackage.CreateComponet("Role", "PromoteItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_txt_desc = (GRichTextField)GetChildAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
        }
    }
}