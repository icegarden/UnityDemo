/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemComposeSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n24;
        public GImage m_n47;
        public GImage m_n25;
        public GImage m_n52;
        public GImage m_n27;
        public GComponent m_item_origin;
        public GComponent m_item_target;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_cost;
        public GTextInput m_txt_composeCount;
        public GList m_list_item;
        public GComponent m_item_cost;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_cancel;
        public GButton m_btn_compose;
        public const string URL = "ui://e98lwrlopcju1j";

        public static UI_ItemComposeSkin CreateInstance()
        {
            return (UI_ItemComposeSkin)UIPackage.CreateComponet("Bag", "ItemComposeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n24 = (GImage)GetChildAt(1);
            m_n47 = (GImage)GetChildAt(2);
            m_n25 = (GImage)GetChildAt(3);
            m_n52 = (GImage)GetChildAt(4);
            m_n27 = (GImage)GetChildAt(5);
            m_item_origin = (GComponent)GetChildComAt(6);
            m_item_target = (GComponent)GetChildComAt(7);
            m_txt_tip1 = (GTextField)GetChildAt(8);
            m_txt_tip2 = (GTextField)GetChildAt(9);
            m_txt_cost = (GRichTextField)GetChildAt(10);
            m_txt_composeCount = (GTextInput)GetChildAt(11);
            m_list_item = (GList)GetChildComAt(12);
            m_item_cost = (GComponent)GetChildComAt(13);
            m_btn_sub = (GButton)GetChildComAt(14);
            m_btn_add = (GButton)GetChildComAt(15);
            m_btn_slide = (GSlider)GetChildComAt(16);
            m_btn_cancel = (GButton)GetChildComAt(17);
            m_btn_compose = (GButton)GetChildComAt(18);
        }
    }
}