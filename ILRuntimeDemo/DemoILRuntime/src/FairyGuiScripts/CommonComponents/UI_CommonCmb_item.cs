/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonCmb_item : GButton
    {
        public Controller m_button;
        public GImage m_n1;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63rb8826";

        public static UI_CommonCmb_item CreateInstance()
        {
            return (UI_CommonCmb_item)UIPackage.CreateComponet("CommonComponents", "CommonCmb_item");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_title = (GRichTextField)GetChildAt(1);
        }
    }
}