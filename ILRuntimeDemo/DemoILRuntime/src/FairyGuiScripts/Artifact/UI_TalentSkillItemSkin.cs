/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_TalentSkillItemSkin : GComponent
    {
        public GComponent m_n0;
        public GLoader m_img_talent;
        public GLoader m_img_bg;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_skillDesc;
        public const string URL = "ui://0uxg7753d1sk38";

        public static UI_TalentSkillItemSkin CreateInstance()
        {
            return (UI_TalentSkillItemSkin)UIPackage.CreateComponet("Artifact", "TalentSkillItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GComponent)GetChildComAt(0);
            m_img_talent = (GLoader)GetChildAt(1);
            m_img_bg = (GLoader)GetChildAt(2);
            m_txt_name = (GRichTextField)GetChildAt(3);
            m_txt_skillDesc = (GRichTextField)GetChildAt(4);
        }
    }
}