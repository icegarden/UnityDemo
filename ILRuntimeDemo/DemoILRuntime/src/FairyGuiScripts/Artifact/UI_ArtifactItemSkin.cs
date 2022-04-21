/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n6;
        public GImage m_n4;
        public GImage m_n5;
        public GButton m_img_icon;
        public GImage m_n2;
        public const string URL = "ui://0uxg7753gikd1g";

        public static UI_ArtifactItemSkin CreateInstance()
        {
            return (UI_ArtifactItemSkin)UIPackage.CreateComponet("Artifact", "ArtifactItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n6 = (GImage)GetChildAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_img_icon = (GButton)GetChildComAt(3);
            m_n2 = (GImage)GetChildAt(4);
        }
    }
}