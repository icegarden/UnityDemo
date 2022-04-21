/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_SkillItemSelectSkin : GButton
    {
        public Controller m_button;
        public GImage m_n1;
        public GLoader m_img_icon;
        public GImage m_n7;
        public GLoader m_img_tab;
        public GTextField m_txt_level;
        public GImage m_n6;
        public const string URL = "ui://0uxg7753gikd36";

        public static UI_SkillItemSelectSkin CreateInstance()
        {
            return (UI_SkillItemSelectSkin)UIPackage.CreateComponet("Artifact", "SkillItemSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_img_tab = (GLoader)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_n6 = (GImage)GetChildAt(5);
        }
    }
}