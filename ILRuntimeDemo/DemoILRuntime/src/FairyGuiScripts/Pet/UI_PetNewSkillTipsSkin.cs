/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetNewSkillTipsSkin : GComponent
    {
        public Controller m_type;
        public GImage m_n1;
        public GImage m_n3;
        public GImage m_n7;
        public GList m_list_attr;
        public GTextField m_txt_unlock;
        public GComponent m_item_nextSkill;
        public GComponent m_item_curSkill;
        public const string URL = "ui://em095moeh46caw";

        public static UI_PetNewSkillTipsSkin CreateInstance()
        {
            return (UI_PetNewSkillTipsSkin)UIPackage.CreateComponet("Pet", "PetNewSkillTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_list_attr = (GList)GetChildComAt(3);
            m_txt_unlock = (GTextField)GetChildAt(4);
            m_item_nextSkill = (GComponent)GetChildComAt(5);
            m_item_curSkill = (GComponent)GetChildComAt(6);
        }
    }
}