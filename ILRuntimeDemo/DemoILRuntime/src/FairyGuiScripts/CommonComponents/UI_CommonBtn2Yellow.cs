/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonBtn2Yellow : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63qncm1q";

        public static UI_CommonBtn2Yellow CreateInstance()
        {
            return (UI_CommonBtn2Yellow)UIPackage.CreateComponet("CommonComponents", "CommonBtn2Yellow");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_icon = (GLoader)GetChildAt(0);
            m_title = (GRichTextField)GetChildAt(1);
        }
    }
}