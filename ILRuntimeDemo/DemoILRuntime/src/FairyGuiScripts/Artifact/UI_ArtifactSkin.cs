/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactSkin : GComponent
    {
        public GLoader m_bg;
        public GComponent m_con_talent;
        public GList m_list_slot;
        public GImage m_n72;
        public GButton m_btn_back;
        public const string URL = "ui://0uxg7753oii80";

        public static UI_ArtifactSkin CreateInstance()
        {
            return (UI_ArtifactSkin)UIPackage.CreateComponet("Artifact", "ArtifactSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_con_talent = (GComponent)GetChildComAt(1);
            m_list_slot = (GList)GetChildComAt(2);
            m_n72 = (GImage)GetChildAt(3);
            m_btn_back = (GButton)GetChildComAt(4);
        }
    }
}