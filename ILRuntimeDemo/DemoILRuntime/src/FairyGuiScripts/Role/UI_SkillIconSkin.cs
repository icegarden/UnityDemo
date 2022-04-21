/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_SkillIconSkin : GComponent
    {
        public Controller m_state;
        public Controller m_type;
        public GImage m_img_select;
        public GButton m_img_icon;
        public GImage m_img_slot;
        public GImage m_n3;
        public GImage m_n6;
        public GImage m_n4;
        public GTextField m_txt_level;
        public GImage m_n11;
        public const string URL = "ui://edfpwlj6sirw3d";

        public static UI_SkillIconSkin CreateInstance()
        {
            return (UI_SkillIconSkin)UIPackage.CreateComponet("Role", "SkillIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_type = GetControllerAt(1);
            m_img_select = (GImage)GetChildAt(0);
            m_img_icon = (GButton)GetChildComAt(1);
            m_img_slot = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n6 = (GImage)GetChildAt(4);
            m_n4 = (GImage)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_n11 = (GImage)GetChildAt(7);
        }
    }
}