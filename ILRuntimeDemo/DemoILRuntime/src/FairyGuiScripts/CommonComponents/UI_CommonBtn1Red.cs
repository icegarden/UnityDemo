/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonBtn1Red : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63g1mw5x";

        public static UI_CommonBtn1Red CreateInstance()
        {
            return (UI_CommonBtn1Red)UIPackage.CreateComponet("CommonComponents", "CommonBtn1Red");
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