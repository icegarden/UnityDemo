/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonBarSkin : GProgressBar
    {
        public GImage m_bg;
        public GLoader m_bar;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63u5ns5d";

        public static UI_CommonBarSkin CreateInstance()
        {
            return (UI_CommonBarSkin)UIPackage.CreateComponet("CommonComponents", "CommonBarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_bar = (GLoader)GetChildAt(1);
            m_title = (GRichTextField)GetChildAt(2);
        }
    }
}