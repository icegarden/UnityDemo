/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetOwnSkillTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n22;
        public GTextField m_txt_name;
        public GTextField m_txt_tip1;
        public GRichTextField m_txt_desc;
        public UI_PetWakeSkillItemSkin m_item_wake1;
        public UI_PetWakeSkillItemSkin m_item_wake2;
        public UI_PetWakeSkillItemSkin m_item_wake3;
        public GComponent m_icon_skill;
        public const string URL = "ui://em095moexxxi4u";

        public static UI_PetOwnSkillTipsSkin CreateInstance()
        {
            return (UI_PetOwnSkillTipsSkin)UIPackage.CreateComponet("Pet", "PetOwnSkillTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n22 = (GImage)GetChildAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_txt_tip1 = (GTextField)GetChildAt(3);
            m_txt_desc = (GRichTextField)GetChildAt(4);
            m_item_wake1 = (UI_PetWakeSkillItemSkin)GetChildComAt(5);
            m_item_wake2 = (UI_PetWakeSkillItemSkin)GetChildComAt(6);
            m_item_wake3 = (UI_PetWakeSkillItemSkin)GetChildComAt(7);
            m_icon_skill = (GComponent)GetChildComAt(8);
        }
    }
}