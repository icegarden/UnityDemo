/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonBtn2Brown : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63g1mw5z";

        public static UI_CommonBtn2Brown CreateInstance()
        {
            return (UI_CommonBtn2Brown)UIPackage.CreateComponet("CommonComponents", "CommonBtn2Brown");
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