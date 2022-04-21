/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_BackBtn : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public const string URL = "ui://0qeyzr63rb8823";

        public static UI_BackBtn CreateInstance()
        {
            return (UI_BackBtn)UIPackage.CreateComponet("CommonComponents", "BackBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
        }
    }
}