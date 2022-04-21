/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_BatchBuySkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_count;
        public GButton m_btn_cancel;
        public GButton m_btn_buy;
        public GImage m_n39;
        public GImage m_n40;
        public GRichTextField m_txt_desc;
        public GTextInput m_txt_buyCount;
        public GTextField m_txt_cost;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GComponent m_item_cost;
        public const string URL = "ui://v22o2wamycl7b";

        public static UI_BatchBuySkin CreateInstance()
        {
            return (UI_BatchBuySkin)UIPackage.CreateComponet("Shop", "BatchBuySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_type = (GTextField)GetChildAt(3);
            m_txt_count = (GTextField)GetChildAt(4);
            m_btn_cancel = (GButton)GetChildComAt(5);
            m_btn_buy = (GButton)GetChildComAt(6);
            m_n39 = (GImage)GetChildAt(7);
            m_n40 = (GImage)GetChildAt(8);
            m_txt_desc = (GRichTextField)GetChildAt(9);
            m_txt_buyCount = (GTextInput)GetChildAt(10);
            m_txt_cost = (GTextField)GetChildAt(11);
            m_btn_sub = (GButton)GetChildComAt(12);
            m_btn_add = (GButton)GetChildComAt(13);
            m_btn_slide = (GSlider)GetChildComAt(14);
            m_item_cost = (GComponent)GetChildComAt(15);
        }
    }
}