/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactMainSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public UI_ArtifactSkin m_view_base;
        public GImage m_n38;
        public GButton m_btn_base;
        public GButton m_btn_back;
        public GButton m_btn_welfare;
        public const string URL = "ui://0uxg7753rb8814";

        public static UI_ArtifactMainSkin CreateInstance()
        {
            return (UI_ArtifactMainSkin)UIPackage.CreateComponet("Artifact", "ArtifactMainSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_view_base = (UI_ArtifactSkin)GetChildComAt(1);
            m_n38 = (GImage)GetChildAt(2);
            m_btn_base = (GButton)GetChildComAt(3);
            m_btn_back = (GButton)GetChildComAt(4);
            m_btn_welfare = (GButton)GetChildComAt(5);
        }
    }
}