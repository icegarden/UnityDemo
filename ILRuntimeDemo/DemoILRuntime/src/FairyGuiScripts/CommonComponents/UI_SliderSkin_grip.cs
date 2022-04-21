/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SliderSkin_grip : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public const string URL = "ui://0qeyzr63qncm1s";

        public static UI_SliderSkin_grip CreateInstance()
        {
            return (UI_SliderSkin_grip)UIPackage.CreateComponet("CommonComponents", "SliderSkin_grip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
        }
    }
}