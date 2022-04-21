/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipRemouldSkin : GComponent
    {
        public GLoader m_bg;
        public GList m_list_item;
        public GButton m_btn_upstar;
        public GTextField m_n5;
        public const string URL = "ui://6uax1a6mdibi3";

        public static UI_ShipRemouldSkin CreateInstance()
        {
            return (UI_ShipRemouldSkin)UIPackage.CreateComponet("Ship", "ShipRemouldSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_btn_upstar = (GButton)GetChildComAt(2);
            m_n5 = (GTextField)GetChildAt(3);
        }
    }
}