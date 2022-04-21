/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSkillItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public GComponent m_item_skill;
        public const string URL = "ui://em095moexxxi4x";

        public static UI_PetSkillItemSkin CreateInstance()
        {
            return (UI_PetSkillItemSkin)UIPackage.CreateComponet("Pet", "PetSkillItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_txt_name = (GTextField)GetChildAt(1);
            m_txt_desc = (GRichTextField)GetChildAt(2);
            m_item_skill = (GComponent)GetChildComAt(3);
        }
    }
}