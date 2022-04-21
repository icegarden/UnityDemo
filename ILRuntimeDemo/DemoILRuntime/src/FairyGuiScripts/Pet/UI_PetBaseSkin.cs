/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetBaseSkin : GComponent
    {
        public GImage m_bg;
        public GList m_list_attr;
        public UI_PetUpgradeOpSkin m_com_upgrade;
        public UI_PetSkillIconSkin m_skill0;
        public UI_PetSkillIconSkin m_skill1;
        public UI_PetSkillIconSkin m_skill2;
        public UI_PetSkillIconSkin m_skill3;
        public UI_PetSkillIconSkin m_ownSkill;
        public GImage m_n72;
        public GButton m_btn_detail;
        public const string URL = "ui://em095moert0b7";

        public static UI_PetBaseSkin CreateInstance()
        {
            return (UI_PetBaseSkin)UIPackage.CreateComponet("Pet", "PetBaseSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_list_attr = (GList)GetChildComAt(1);
            m_com_upgrade = (UI_PetUpgradeOpSkin)GetChildComAt(2);
            m_skill0 = (UI_PetSkillIconSkin)GetChildComAt(3);
            m_skill1 = (UI_PetSkillIconSkin)GetChildComAt(4);
            m_skill2 = (UI_PetSkillIconSkin)GetChildComAt(5);
            m_skill3 = (UI_PetSkillIconSkin)GetChildComAt(6);
            m_ownSkill = (UI_PetSkillIconSkin)GetChildComAt(7);
            m_n72 = (GImage)GetChildAt(8);
            m_btn_detail = (GButton)GetChildComAt(9);
        }
    }
}