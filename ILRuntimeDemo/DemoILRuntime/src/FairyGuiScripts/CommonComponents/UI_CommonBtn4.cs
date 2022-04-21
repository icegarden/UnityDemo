/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonBtn4 : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public GRichTextField m_title;
        public const string URL = "ui://0qeyzr63rznq58";

        public static UI_CommonBtn4 CreateInstance()
        {
            return (UI_CommonBtn4)UIPackage.CreateComponet("CommonComponents", "CommonBtn4");
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