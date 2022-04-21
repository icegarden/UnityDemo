/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_Exploreing : GButton
    {
        public Controller m_button;
        public GImage m_n4;
        public GTextField m_title;
        public const string URL = "ui://uwx2vhvshioo1c";

        public static UI_Exploreing CreateInstance()
        {
            return (UI_Exploreing)UIPackage.CreateComponet("Dungeon", "Exploreing");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n4 = (GImage)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
        }
    }
}