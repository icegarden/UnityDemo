/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipSkin : GComponent
    {
        public GLoader m_bg;
        public GLabel m_title;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GImage m_n9;
        public GTextField m_txt_count;
        public GList m_list_item;
        public const string URL = "ui://6uax1a6mdibi0";

        public static UI_ShipSkin CreateInstance()
        {
            return (UI_ShipSkin)UIPackage.CreateComponet("Ship", "ShipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_img_bottom = (GLoader)GetChildAt(2);
            m_btn_back = (GButton)GetChildComAt(3);
            m_n9 = (GImage)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
        }
    }
}