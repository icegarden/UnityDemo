/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonTab1 : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n1;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63c6ya8";

        public static UI_CommonTab1 CreateInstance()
        {
            return (UI_CommonTab1)UIPackage.CreateComponet("CommonComponents", "CommonTab1");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_title = (GRichTextField)GetChildAt(2);
        }
    }
}