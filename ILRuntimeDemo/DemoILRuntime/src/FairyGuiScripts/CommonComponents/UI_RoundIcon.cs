/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_RoundIcon : GButton
    {
        public GLoader m_icon;
        public GGraph m_mask;
        public const string URL = "ui://0qeyzr63rb881z";

        public static UI_RoundIcon CreateInstance()
        {
            return (UI_RoundIcon)UIPackage.CreateComponet("CommonComponents", "RoundIcon");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
            m_mask = (GGraph)GetChildAt(1);
        }
    }
}