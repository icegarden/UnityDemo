/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemBatchUseSkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_item;
        public GImage m_n39;
        public GImage m_n40;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_count;
        public GTextInput m_txt_useCount;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_cancel;
        public GButton m_btn_use;
        public const string URL = "ui://e98lwrlopcju1e";

        public static UI_ItemBatchUseSkin CreateInstance()
        {
            return (UI_ItemBatchUseSkin)UIPackage.CreateComponet("Bag", "ItemBatchUseSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_n39 = (GImage)GetChildAt(2);
            m_n40 = (GImage)GetChildAt(3);
            m_txt_desc = (GRichTextField)GetChildAt(4);
            m_txt_name = (GRichTextField)GetChildAt(5);
            m_txt_type = (GTextField)GetChildAt(6);
            m_txt_count = (GTextField)GetChildAt(7);
            m_txt_useCount = (GTextInput)GetChildAt(8);
            m_btn_sub = (GButton)GetChildComAt(9);
            m_btn_add = (GButton)GetChildComAt(10);
            m_btn_slide = (GSlider)GetChildComAt(11);
            m_btn_cancel = (GButton)GetChildComAt(12);
            m_btn_use = (GButton)GetChildComAt(13);
        }
    }
}