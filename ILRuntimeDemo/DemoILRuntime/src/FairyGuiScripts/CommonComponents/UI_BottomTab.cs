/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_BottomTab : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n1;
        public GLoader m_icon;
        public const string URL = "ui://0qeyzr63rb8837";

        public static UI_BottomTab CreateInstance()
        {
            return (UI_BottomTab)UIPackage.CreateComponet("CommonComponents", "BottomTab");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_icon = (GLoader)GetChildAt(2);
        }
    }
}