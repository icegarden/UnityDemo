/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PanelTitleSkin : GLabel
    {
        public GLoader m_img_bg;
        public GImage m_n1;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63sirw57";

        public static UI_PanelTitleSkin CreateInstance()
        {
            return (UI_PanelTitleSkin)UIPackage.CreateComponet("CommonComponents", "PanelTitleSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_title = (GRichTextField)GetChildAt(2);
        }
    }
}