/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactTalentLineSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public const string URL = "ui://0uxg7753oii83";

        public static UI_ArtifactTalentLineSkin CreateInstance()
        {
            return (UI_ArtifactTalentLineSkin)UIPackage.CreateComponet("Artifact", "ArtifactTalentLineSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
        }
    }
}