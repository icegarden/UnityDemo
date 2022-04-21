/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_Icon3Btn : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public GLoader m_icon;
        public const string URL = "ui://0qeyzr63ivj51g";

        public static UI_Icon3Btn CreateInstance()
        {
            return (UI_Icon3Btn)UIPackage.CreateComponet("CommonComponents", "Icon3Btn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
        }
    }
}