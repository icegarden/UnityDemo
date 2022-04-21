/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_StarItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n1;
        public GImage m_n2;
        public const string URL = "ui://0qeyzr639hynp";

        public static UI_StarItemSkin CreateInstance()
        {
            return (UI_StarItemSkin)UIPackage.CreateComponet("CommonComponents", "StarItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
        }
    }
}