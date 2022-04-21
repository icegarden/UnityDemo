/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactSkillIconSkin : GComponent
    {
        public GImage m_n1;
        public GLoader m_img_icon;
        public GImage m_n5;
        public GLoader m_img_tab;
        public GTextField m_txt_level;
        public const string URL = "ui://0uxg7753pcju19";

        public static UI_ArtifactSkillIconSkin CreateInstance()
        {
            return (UI_ArtifactSkillIconSkin)UIPackage.CreateComponet("Artifact", "ArtifactSkillIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_img_tab = (GLoader)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
        }
    }
}