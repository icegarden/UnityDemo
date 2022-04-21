/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetWakeSkillItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n7;
        public GLoader m_img_icon;
        public GTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public GImage m_n10;
        public const string URL = "ui://em095moexxxi4l";

        public static UI_PetWakeSkillItemSkin CreateInstance()
        {
            return (UI_PetWakeSkillItemSkin)UIPackage.CreateComponet("Pet", "PetWakeSkillItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n7 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
            m_n10 = (GImage)GetChildAt(4);
        }
    }
}