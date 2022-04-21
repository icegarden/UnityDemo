/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SelectChk : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public GImage m_n5;
        public const string URL = "ui://0qeyzr63pcjub";

        public static UI_SelectChk CreateInstance()
        {
            return (UI_SelectChk)UIPackage.CreateComponet("CommonComponents", "SelectChk");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
        }
    }
}