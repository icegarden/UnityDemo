/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipCardItemSkin : GComponent
    {
        public GImage m_n4;
        public GLoader m_img_icon;
        public GImage m_n5;
        public GList m_list_star;
        public GTextField m_txt_name;
        public const string URL = "ui://6uax1a6mdibi1";

        public static UI_ShipCardItemSkin CreateInstance()
        {
            return (UI_ShipCardItemSkin)UIPackage.CreateComponet("Ship", "ShipCardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_list_star = (GList)GetChildComAt(3);
            m_txt_name = (GTextField)GetChildAt(4);
        }
    }
}