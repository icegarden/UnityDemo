/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSkillIconSkin : GComponent
    {
        public Controller m_state;
        public GButton m_img_icon;
        public GImage m_n9;
        public GImage m_n10;
        public GTextField m_txt_unlockLevel;
        public GTextField m_txt_level;
        public const string URL = "ui://em095moert0b8";

        public static UI_PetSkillIconSkin CreateInstance()
        {
            return (UI_PetSkillIconSkin)UIPackage.CreateComponet("Pet", "PetSkillIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_icon = (GButton)GetChildComAt(0);
            m_n9 = (GImage)GetChildAt(1);
            m_n10 = (GImage)GetChildAt(2);
            m_txt_unlockLevel = (GTextField)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
        }
    }
}