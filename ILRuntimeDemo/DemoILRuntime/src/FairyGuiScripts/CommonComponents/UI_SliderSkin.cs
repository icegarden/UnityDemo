/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SliderSkin : GSlider
    {
        public GImage m_n0;
        public GImage m_bar;
        public UI_SliderSkin_grip m_grip;
        public const string URL = "ui://0qeyzr63qncm1t";

        public static UI_SliderSkin CreateInstance()
        {
            return (UI_SliderSkin)UIPackage.CreateComponet("CommonComponents", "SliderSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_bar = (GImage)GetChildAt(1);
            m_grip = (UI_SliderSkin_grip)GetChildComAt(2);
        }
    }
}