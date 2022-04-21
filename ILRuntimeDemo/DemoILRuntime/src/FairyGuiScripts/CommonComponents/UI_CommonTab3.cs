/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonTab3 : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public GImage m_n5;
        public GTextField m_title;
        public const string URL = "ui://0qeyzr63gl3762";

        public static UI_CommonTab3 CreateInstance()
        {
            return (UI_CommonTab3)UIPackage.CreateComponet("CommonComponents", "CommonTab3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}