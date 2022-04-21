/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipPartRemouldSkin : GComponent
    {
        public GLoader m_bg;
        public GImage m_n18;
        public GImage m_n19;
        public GImage m_n20;
        public GImage m_n21;
        public GImage m_n22;
        public GImage m_n23;
        public GImage m_n24;
        public GLoader m_img_icon;
        public GImage m_n25;
        public GImage m_n10;
        public GImage m_n9;
        public GRichTextField m_txt_name;
        public GTextField m_txt_remoulded;
        public GTextField m_n12;
        public GList m_list_cost;
        public GList m_list_attr;
        public GButton m_btn_remould;
        public GList m_list_star;
        public const string URL = "ui://6uax1a6mdibi6";

        public static UI_ShipPartRemouldSkin CreateInstance()
        {
            return (UI_ShipPartRemouldSkin)UIPackage.CreateComponet("Ship", "ShipPartRemouldSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_n18 = (GImage)GetChildAt(1);
            m_n19 = (GImage)GetChildAt(2);
            m_n20 = (GImage)GetChildAt(3);
            m_n21 = (GImage)GetChildAt(4);
            m_n22 = (GImage)GetChildAt(5);
            m_n23 = (GImage)GetChildAt(6);
            m_n24 = (GImage)GetChildAt(7);
            m_img_icon = (GLoader)GetChildAt(8);
            m_n25 = (GImage)GetChildAt(9);
            m_n10 = (GImage)GetChildAt(10);
            m_n9 = (GImage)GetChildAt(11);
            m_txt_name = (GRichTextField)GetChildAt(12);
            m_txt_remoulded = (GTextField)GetChildAt(13);
            m_n12 = (GTextField)GetChildAt(14);
            m_list_cost = (GList)GetChildComAt(15);
            m_list_attr = (GList)GetChildComAt(16);
            m_btn_remould = (GButton)GetChildComAt(17);
            m_list_star = (GList)GetChildComAt(18);
        }
    }
}