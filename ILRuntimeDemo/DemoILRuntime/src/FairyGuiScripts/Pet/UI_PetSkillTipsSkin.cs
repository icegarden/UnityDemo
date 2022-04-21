/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSkillTipsSkin : GComponent
    {
        public GImage m_bg;
        public GImage m_n17;
        public GGraph m_line;
        public GButton m_icon_skill;
        public GImage m_n15;
        public GTextField m_txt_tip1;
        public GTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_level;
        public GTextField m_txt_unlock;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_cost;
        public GTextField m_txt_cd;
        public const string URL = "ui://em095moert0bk";

        public static UI_PetSkillTipsSkin CreateInstance()
        {
            return (UI_PetSkillTipsSkin)UIPackage.CreateComponet("Pet", "PetSkillTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_n17 = (GImage)GetChildAt(1);
            m_line = (GGraph)GetChildAt(2);
            m_icon_skill = (GButton)GetChildComAt(3);
            m_n15 = (GImage)GetChildAt(4);
            m_txt_tip1 = (GTextField)GetChildAt(5);
            m_txt_name = (GTextField)GetChildAt(6);
            m_txt_type = (GTextField)GetChildAt(7);
            m_txt_level = (GTextField)GetChildAt(8);
            m_txt_unlock = (GTextField)GetChildAt(9);
            m_txt_desc = (GRichTextField)GetChildAt(10);
            m_txt_cost = (GTextField)GetChildAt(11);
            m_txt_cd = (GTextField)GetChildAt(12);
        }
    }
}