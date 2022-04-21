/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEnegySkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n46;
        public GImage m_n47;
        public GImage m_n40;
        public GList m_list_item;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_use;
        public UI_EnegyBar2 m_pb_count;
        public GRichTextField m_txt_count;
        public GRichTextField m_txt_time;
        public GTextField m_txt_tip1;
        public GRichTextField m_txt_desc;
        public GTextInput m_txt_useCount;
        public const string URL = "ui://63ubk2jodibig";

        public static UI_WorldEnegySkin CreateInstance()
        {
            return (UI_WorldEnegySkin)UIPackage.CreateComponet("World", "WorldEnegySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n46 = (GImage)GetChildAt(1);
            m_n47 = (GImage)GetChildAt(2);
            m_n40 = (GImage)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_btn_sub = (GButton)GetChildComAt(5);
            m_btn_add = (GButton)GetChildComAt(6);
            m_btn_slide = (GSlider)GetChildComAt(7);
            m_btn_use = (GButton)GetChildComAt(8);
            m_pb_count = (UI_EnegyBar2)GetChildComAt(9);
            m_txt_count = (GRichTextField)GetChildAt(10);
            m_txt_time = (GRichTextField)GetChildAt(11);
            m_txt_tip1 = (GTextField)GetChildAt(12);
            m_txt_desc = (GRichTextField)GetChildAt(13);
            m_txt_useCount = (GTextInput)GetChildAt(14);
        }
    }
}