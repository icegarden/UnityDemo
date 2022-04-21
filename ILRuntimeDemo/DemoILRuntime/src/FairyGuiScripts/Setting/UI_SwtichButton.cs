/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SwtichButton : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n1;
        public const string URL = "ui://wi3k1s54j3xsx";

        public static UI_SwtichButton CreateInstance()
        {
            return (UI_SwtichButton)UIPackage.CreateComponet("Setting", "SwtichButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
        }
    }
}