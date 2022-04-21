/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_SkillTextItemSkin : GComponent
    {
        public GRichTextField m_txt_content;
        public const string URL = "ui://e98lwrlorb882m";

        public static UI_SkillTextItemSkin CreateInstance()
        {
            return (UI_SkillTextItemSkin)UIPackage.CreateComponet("Bag", "SkillTextItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_content = (GRichTextField)GetChildAt(0);
        }
    }
}