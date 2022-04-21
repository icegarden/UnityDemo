/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_FarmSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_bg_slot;
        public GImage m_n23;
        public GImage m_n25;
        public GImage m_n26;
        public GImage m_n27;
        public GLabel m_n17;
        public GComponent m_n6;
        public GImage m_n2;
        public GImage m_n7;
        public GImage m_n16;
        public GTextField m_n8;
        public GList m_list_item;
        public GList m_list_slot;
        public GButton m_btn_back;
        public GButton m_btn_harvest;
        public GButton m_btn_water;
        public GButton m_btn_plant;
        public const string URL = "ui://wua6gzxlikzm1d";

        public static UI_FarmSkin CreateInstance()
        {
            return (UI_FarmSkin)UIPackage.CreateComponet("Home", "FarmSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_bg_slot = (GLoader)GetChildAt(1);
            m_n23 = (GImage)GetChildAt(2);
            m_n25 = (GImage)GetChildAt(3);
            m_n26 = (GImage)GetChildAt(4);
            m_n27 = (GImage)GetChildAt(5);
            m_n17 = (GLabel)GetChildComAt(6);
            m_n6 = (GComponent)GetChildComAt(7);
            m_n2 = (GImage)GetChildAt(8);
            m_n7 = (GImage)GetChildAt(9);
            m_n16 = (GImage)GetChildAt(10);
            m_n8 = (GTextField)GetChildAt(11);
            m_list_item = (GList)GetChildComAt(12);
            m_list_slot = (GList)GetChildComAt(13);
            m_btn_back = (GButton)GetChildComAt(14);
            m_btn_harvest = (GButton)GetChildComAt(15);
            m_btn_water = (GButton)GetChildComAt(16);
            m_btn_plant = (GButton)GetChildComAt(17);
        }
    }
}