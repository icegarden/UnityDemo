/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipRemouldItemSkin : GComponent
    {
        public GImage m_n4;
        public GImage m_n5;
        public GList m_list_item;
        public GList m_list_star;
        public GTextField m_txt_tip;
        public const string URL = "ui://6uax1a6mdibi4";

        public static UI_ShipRemouldItemSkin CreateInstance()
        {
            return (UI_ShipRemouldItemSkin)UIPackage.CreateComponet("Ship", "ShipRemouldItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
            m_list_star = (GList)GetChildComAt(3);
            m_txt_tip = (GTextField)GetChildAt(4);
        }
    }
}