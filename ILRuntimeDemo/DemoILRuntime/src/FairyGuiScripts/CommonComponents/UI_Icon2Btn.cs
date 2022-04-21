/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_Icon2Btn : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GLoader m_icon;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63ikzm28";

        public static UI_Icon2Btn CreateInstance()
        {
            return (UI_Icon2Btn)UIPackage.CreateComponet("CommonComponents", "Icon2Btn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_title = (GRichTextField)GetChildAt(2);
        }
    }
}