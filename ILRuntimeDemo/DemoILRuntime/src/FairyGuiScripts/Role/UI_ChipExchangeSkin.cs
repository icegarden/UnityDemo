/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_ChipExchangeSkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_item1;
        public GImage m_n32;
        public GRichTextField m_txt_cost;
        public GTextInput m_txt_useCount;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_cancel;
        public GButton m_btn_exchange;
        public GComponent m_item2;
        public GImage m_n39;
        public GRichTextField m_txt_count1;
        public GRichTextField m_txt_count2;
        public GRichTextField m_txt_left;
        public const string URL = "ui://edfpwlj6dibi3p";

        public static UI_ChipExchangeSkin CreateInstance()
        {
            return (UI_ChipExchangeSkin)UIPackage.CreateComponet("Role", "ChipExchangeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_item1 = (GComponent)GetChildComAt(1);
            m_n32 = (GImage)GetChildAt(2);
            m_txt_cost = (GRichTextField)GetChildAt(3);
            m_txt_useCount = (GTextInput)GetChildAt(4);
            m_btn_sub = (GButton)GetChildComAt(5);
            m_btn_add = (GButton)GetChildComAt(6);
            m_btn_slide = (GSlider)GetChildComAt(7);
            m_btn_cancel = (GButton)GetChildComAt(8);
            m_btn_exchange = (GButton)GetChildComAt(9);
            m_item2 = (GComponent)GetChildComAt(10);
            m_n39 = (GImage)GetChildAt(11);
            m_txt_count1 = (GRichTextField)GetChildAt(12);
            m_txt_count2 = (GRichTextField)GetChildAt(13);
            m_txt_left = (GRichTextField)GetChildAt(14);
        }
    }
}