/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SkillIconSkin : GComponent
    {
        public GImage m_n2;
        public UI_RoundIcon m_img_icon;
        public GImage m_n1;
        public GTextField m_txt_level;
        public const string URL = "ui://0qeyzr63sig265";

        public static UI_SkillIconSkin CreateInstance()
        {
            return (UI_SkillIconSkin)UIPackage.CreateComponet("CommonComponents", "SkillIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_img_icon = (UI_RoundIcon)GetChildComAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_txt_level = (GTextField)GetChildAt(3);
        }
    }
}