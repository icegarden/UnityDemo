/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactTalentItemSkin : GComponent
    {
        public GButton m_img_icon;
        public GLoader m_img_bg;
        public GRichTextField m_txt_level;
        public const string URL = "ui://0uxg7753oii82";

        public static UI_ArtifactTalentItemSkin CreateInstance()
        {
            return (UI_ArtifactTalentItemSkin)UIPackage.CreateComponet("Artifact", "ArtifactTalentItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GButton)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_txt_level = (GRichTextField)GetChildAt(2);
        }
    }
}