/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PopupSkin : GComponent
    {
        public GImage m_bg_tip;
        public GRichTextField m_txt_tip;
        public const string URL = "ui://0qeyzr63sig269";

        public static UI_PopupSkin CreateInstance()
        {
            return (UI_PopupSkin)UIPackage.CreateComponet("CommonComponents", "PopupSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg_tip = (GImage)GetChildAt(0);
            m_txt_tip = (GRichTextField)GetChildAt(1);
        }
    }
}