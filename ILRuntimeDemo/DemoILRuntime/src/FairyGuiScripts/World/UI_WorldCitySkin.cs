/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldCitySkin : GComponent
    {
        public GLoader m_img_floor;
        public UI_WorldCityMapSkin m_view_map;
        public GLoader m_img_top;
        public GTextField m_txt_name;
        public GButton m_btn_defense;
        public GButton m_btn_talent;
        public GGroup m_top_group;
        public GLoader m_img_bottom;
        public GImage m_n29;
        public GImage m_n30;
        public GTextField m_txt_count;
        public GTextField m_txt_maxCount;
        public GTextField m_txt_enegy;
        public GTextField m_txt_time;
        public GTextField m_txt_event;
        public GRichTextField m_txt_costOne;
        public GRichTextField m_txt_costTen;
        public GButton m_btn_addEnegy;
        public GButton m_btn_ten;
        public GButton m_btn_one;
        public UI_EnegyBar1 m_pb_enegy;
        public GGroup m_bottom_group;
        public GButton m_btn_close;
        public const string URL = "ui://63ubk2jodibiv";

        public static UI_WorldCitySkin CreateInstance()
        {
            return (UI_WorldCitySkin)UIPackage.CreateComponet("World", "WorldCitySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_floor = (GLoader)GetChildAt(0);
            m_view_map = (UI_WorldCityMapSkin)GetChildComAt(1);
            m_img_top = (GLoader)GetChildAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
            m_btn_defense = (GButton)GetChildComAt(4);
            m_btn_talent = (GButton)GetChildComAt(5);
            m_top_group = (GGroup)GetChildAt(6);
            m_img_bottom = (GLoader)GetChildAt(7);
            m_n29 = (GImage)GetChildAt(8);
            m_n30 = (GImage)GetChildAt(9);
            m_txt_count = (GTextField)GetChildAt(10);
            m_txt_maxCount = (GTextField)GetChildAt(11);
            m_txt_enegy = (GTextField)GetChildAt(12);
            m_txt_time = (GTextField)GetChildAt(13);
            m_txt_event = (GTextField)GetChildAt(14);
            m_txt_costOne = (GRichTextField)GetChildAt(15);
            m_txt_costTen = (GRichTextField)GetChildAt(16);
            m_btn_addEnegy = (GButton)GetChildComAt(17);
            m_btn_ten = (GButton)GetChildComAt(18);
            m_btn_one = (GButton)GetChildComAt(19);
            m_pb_enegy = (UI_EnegyBar1)GetChildComAt(20);
            m_bottom_group = (GGroup)GetChildAt(21);
            m_btn_close = (GButton)GetChildComAt(22);
        }
    }
}