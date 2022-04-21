/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_PlantSpeedupSkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_n29;
        public GComponent m_n41;
        public GImage m_n35;
        public GComponent m_item;
        public GList m_list_item;
        public GLabel m_txt_desc;
        public GRichTextField m_txt_name;
        public GTextField m_txt_produceCount;
        public GTextField m_txt_lefttime;
        public GTextField m_n43;
        public GTextField m_n45;
        public GTextField m_n46;
        public GRichTextField m_txt_cost;
        public GTextField m_txt_time;
        public GTextInput m_txt_useCount;
        public GSlider m_btn_slide;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GButton m_btn_use;
        public GGroup m_n53;
        public const string URL = "ui://wua6gzxlikzm1n";

        public static UI_PlantSpeedupSkin CreateInstance()
        {
            return (UI_PlantSpeedupSkin)UIPackage.CreateComponet("Home", "PlantSpeedupSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n29 = (GComponent)GetChildComAt(1);
            m_n41 = (GComponent)GetChildComAt(2);
            m_n35 = (GImage)GetChildAt(3);
            m_item = (GComponent)GetChildComAt(4);
            m_list_item = (GList)GetChildComAt(5);
            m_txt_desc = (GLabel)GetChildComAt(6);
            m_txt_name = (GRichTextField)GetChildAt(7);
            m_txt_produceCount = (GTextField)GetChildAt(8);
            m_txt_lefttime = (GTextField)GetChildAt(9);
            m_n43 = (GTextField)GetChildAt(10);
            m_n45 = (GTextField)GetChildAt(11);
            m_n46 = (GTextField)GetChildAt(12);
            m_txt_cost = (GRichTextField)GetChildAt(13);
            m_txt_time = (GTextField)GetChildAt(14);
            m_txt_useCount = (GTextInput)GetChildAt(15);
            m_btn_slide = (GSlider)GetChildComAt(16);
            m_btn_sub = (GButton)GetChildComAt(17);
            m_btn_add = (GButton)GetChildComAt(18);
            m_btn_use = (GButton)GetChildComAt(19);
            m_n53 = (GGroup)GetChildAt(20);
        }
    }
}