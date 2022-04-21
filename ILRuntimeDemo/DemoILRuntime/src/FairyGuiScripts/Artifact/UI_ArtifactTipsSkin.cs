/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactTipsSkin : GComponent
    {
        public GLabel m_n0;
        public GImage m_n5;
        public GImage m_n7;
        public GGraph m_n16;
        public GGraph m_n18;
        public GTextField m_txt_tip3;
        public GTextField m_txt_tip4;
        public GList m_list_talentAttr;
        public GList m_list_skill;
        public const string URL = "ui://0uxg7753dibi3a";

        public static UI_ArtifactTipsSkin CreateInstance()
        {
            return (UI_ArtifactTipsSkin)UIPackage.CreateComponet("Artifact", "ArtifactTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GLabel)GetChildComAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n16 = (GGraph)GetChildAt(3);
            m_n18 = (GGraph)GetChildAt(4);
            m_txt_tip3 = (GTextField)GetChildAt(5);
            m_txt_tip4 = (GTextField)GetChildAt(6);
            m_list_talentAttr = (GList)GetChildComAt(7);
            m_list_skill = (GList)GetChildComAt(8);
        }
    }
}