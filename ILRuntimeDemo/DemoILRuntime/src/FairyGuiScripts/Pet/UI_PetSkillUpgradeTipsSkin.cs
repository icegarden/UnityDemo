/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSkillUpgradeTipsSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GImage m_n36;
        public GImage m_n37;
        public GComponent m_item_nextSkill;
        public GComponent m_item_curSkill;
        public GTextField m_txt_curName;
        public GTextField m_txt_nextName;
        public GList m_list_cost;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public const string URL = "ui://em095moert0bp";

        public static UI_PetSkillUpgradeTipsSkin CreateInstance()
        {
            return (UI_PetSkillUpgradeTipsSkin)UIPackage.CreateComponet("Pet", "PetSkillUpgradeTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n36 = (GImage)GetChildAt(1);
            m_n37 = (GImage)GetChildAt(2);
            m_item_nextSkill = (GComponent)GetChildComAt(3);
            m_item_curSkill = (GComponent)GetChildComAt(4);
            m_txt_curName = (GTextField)GetChildAt(5);
            m_txt_nextName = (GTextField)GetChildAt(6);
            m_list_cost = (GList)GetChildComAt(7);
            m_btn_confirm = (GButton)GetChildComAt(8);
            m_btn_cancel = (GButton)GetChildComAt(9);
        }
    }
}