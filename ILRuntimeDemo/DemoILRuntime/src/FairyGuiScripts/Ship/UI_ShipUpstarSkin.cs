/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipUpstarSkin : GComponent
    {
        public GLabel m_bg;
        public GButton m_btn_upstar;
        public GList m_list_attr;
        public GList m_list_cost;
        public const string URL = "ui://6uax1a6mdibi7";

        public static UI_ShipUpstarSkin CreateInstance()
        {
            return (UI_ShipUpstarSkin)UIPackage.CreateComponet("Ship", "ShipUpstarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_btn_upstar = (GButton)GetChildComAt(1);
            m_list_attr = (GList)GetChildComAt(2);
            m_list_cost = (GList)GetChildComAt(3);
        }
    }
}