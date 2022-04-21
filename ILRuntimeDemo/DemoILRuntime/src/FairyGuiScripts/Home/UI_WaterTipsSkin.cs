/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_WaterTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GRichTextField m_txt_count;
        public GTextField m_n11;
        public GTextField m_txt_time;
        public GTextField m_txt_free;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GComponent m_item_cost;
        public GGroup m_n15;
        public const string URL = "ui://wua6gzxlxxxi2c";

        public static UI_WaterTipsSkin CreateInstance()
        {
            return (UI_WaterTipsSkin)UIPackage.CreateComponet("Home", "WaterTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_txt_count = (GRichTextField)GetChildAt(1);
            m_n11 = (GTextField)GetChildAt(2);
            m_txt_time = (GTextField)GetChildAt(3);
            m_txt_free = (GTextField)GetChildAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_cancel = (GButton)GetChildComAt(6);
            m_item_cost = (GComponent)GetChildComAt(7);
            m_n15 = (GGroup)GetChildAt(8);
        }
    }
}