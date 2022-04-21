/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonCmb : GComboBox
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n3;
        public GTextField m_title;
        public const string URL = "ui://0qeyzr63rb8824";

        public static UI_CommonCmb CreateInstance()
        {
            return (UI_CommonCmb)UIPackage.CreateComponet("CommonComponents", "CommonCmb");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}