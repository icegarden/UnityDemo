/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactSlotSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GImage m_img_lock;
        public GTextField m_txt_level;
        public const string URL = "ui://0uxg7753oii87";

        public static UI_ArtifactSlotSkin CreateInstance()
        {
            return (UI_ArtifactSlotSkin)UIPackage.CreateComponet("Artifact", "ArtifactSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_lock = (GImage)GetChildAt(2);
            m_txt_level = (GTextField)GetChildAt(3);
        }
    }
}