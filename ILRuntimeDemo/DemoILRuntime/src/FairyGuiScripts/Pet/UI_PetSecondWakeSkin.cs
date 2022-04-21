/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSecondWakeSkin : GComponent
    {
        public GLabel m_n15;
        public GLoader m_img_icon;
        public UI_PetSkillIconSkin m_skill0;
        public UI_PetSkillIconSkin m_skill1;
        public UI_PetSkillIconSkin m_skill2;
        public UI_PetSkillIconSkin m_curSkill;
        public GTextField m_n1;
        public GTextField m_n6;
        public GRichTextField m_txt_skillName;
        public GRichTextField m_txt_skillDesc;
        public GTextField m_n10;
        public GTextField m_txt_activate;
        public GList m_list_attr;
        public GList m_list_cost;
        public GButton m_btn_wake;
        public const string URL = "ui://em095moert0b12";

        public static UI_PetSecondWakeSkin CreateInstance()
        {
            return (UI_PetSecondWakeSkin)UIPackage.CreateComponet("Pet", "PetSecondWakeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n15 = (GLabel)GetChildComAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_skill0 = (UI_PetSkillIconSkin)GetChildComAt(2);
            m_skill1 = (UI_PetSkillIconSkin)GetChildComAt(3);
            m_skill2 = (UI_PetSkillIconSkin)GetChildComAt(4);
            m_curSkill = (UI_PetSkillIconSkin)GetChildComAt(5);
            m_n1 = (GTextField)GetChildAt(6);
            m_n6 = (GTextField)GetChildAt(7);
            m_txt_skillName = (GRichTextField)GetChildAt(8);
            m_txt_skillDesc = (GRichTextField)GetChildAt(9);
            m_n10 = (GTextField)GetChildAt(10);
            m_txt_activate = (GTextField)GetChildAt(11);
            m_list_attr = (GList)GetChildComAt(12);
            m_list_cost = (GList)GetChildComAt(13);
            m_btn_wake = (GButton)GetChildComAt(14);
        }
    }
}