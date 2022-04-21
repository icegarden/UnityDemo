/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ScrollText : GLabel
    {
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63c6ya6";

        public static UI_ScrollText CreateInstance()
        {
            return (UI_ScrollText)UIPackage.CreateComponet("CommonComponents", "ScrollText");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_title = (GRichTextField)GetChildAt(0);
        }
    }
}