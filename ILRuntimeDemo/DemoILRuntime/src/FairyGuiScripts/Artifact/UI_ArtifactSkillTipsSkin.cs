/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactSkillTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_n7;
        public GComponent m_tip1;
        public GComponent m_title_talent;
        public GImage m_img_select;
        public GButton m_img_icon;
        public GImage m_n14;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_type;
        public GTextField m_txt_cd;
        public GRichTextField m_txt_skillDesc;
        public GList m_list_talent;
        public const string URL = "ui://0uxg7753d1sk37";

        public static UI_ArtifactSkillTipsSkin CreateInstance()
        {
            return (UI_ArtifactSkillTipsSkin)UIPackage.CreateComponet("Artifact", "ArtifactSkillTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n7 = (GComponent)GetChildComAt(1);
            m_tip1 = (GComponent)GetChildComAt(2);
            m_title_talent = (GComponent)GetChildComAt(3);
            m_img_select = (GImage)GetChildAt(4);
            m_img_icon = (GButton)GetChildComAt(5);
            m_n14 = (GImage)GetChildAt(6);
            m_txt_name = (GTextField)GetChildAt(7);
            m_txt_level = (GTextField)GetChildAt(8);
            m_txt_type = (GTextField)GetChildAt(9);
            m_txt_cd = (GTextField)GetChildAt(10);
            m_txt_skillDesc = (GRichTextField)GetChildAt(11);
            m_list_talent = (GList)GetChildComAt(12);
        }
    }
}