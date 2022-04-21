/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_TweenBarSkin : GProgressBar
    {
        public GLoader m_bar;
        public GLoader m_slowBar;
        public GImage m_bg;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63k73k6g";

        public static UI_TweenBarSkin CreateInstance()
        {
            return (UI_TweenBarSkin)UIPackage.CreateComponet("CommonComponents", "TweenBarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bar = (GLoader)GetChildAt(0);
            m_slowBar = (GLoader)GetChildAt(1);
            m_bg = (GImage)GetChildAt(2);
            m_title = (GRichTextField)GetChildAt(3);
        }
    }
}