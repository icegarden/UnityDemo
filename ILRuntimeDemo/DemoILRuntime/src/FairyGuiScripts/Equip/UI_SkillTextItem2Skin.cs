/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_SkillTextItem2Skin : GComponent
    {
        public GRichTextField m_txt_content;
        public const string URL = "ui://5ch1xwvwrt0b10";

        public static UI_SkillTextItem2Skin CreateInstance()
        {
            return (UI_SkillTextItem2Skin)UIPackage.CreateComponet("Equip", "SkillTextItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_content = (GRichTextField)GetChildAt(0);
        }
    }
}