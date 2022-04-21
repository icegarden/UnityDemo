/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SelectChk2 : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public GImage m_n6;
        public GTextField m_title;
        public const string URL = "ui://0qeyzr63rt0bn";

        public static UI_SelectChk2 CreateInstance()
        {
            return (UI_SelectChk2)UIPackage.CreateComponet("CommonComponents", "SelectChk2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
            m_n6 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}