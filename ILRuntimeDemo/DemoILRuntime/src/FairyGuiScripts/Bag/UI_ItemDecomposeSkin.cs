/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemDecomposeSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n23;
        public GImage m_n38;
        public GImage m_n25;
        public GImage m_n39;
        public GImage m_n36;
        public GComponent m_item_origin;
        public GComponent m_item_target;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_cost;
        public GTextInput m_txt_decomposeCount;
        public GList m_list_item;
        public GComponent m_item_cost;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_cancel;
        public GButton m_btn_decompose;
        public const string URL = "ui://e98lwrlopcju1k";

        public static UI_ItemDecomposeSkin CreateInstance()
        {
            return (UI_ItemDecomposeSkin)UIPackage.CreateComponet("Bag", "ItemDecomposeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n23 = (GImage)GetChildAt(1);
            m_n38 = (GImage)GetChildAt(2);
            m_n25 = (GImage)GetChildAt(3);
            m_n39 = (GImage)GetChildAt(4);
            m_n36 = (GImage)GetChildAt(5);
            m_item_origin = (GComponent)GetChildComAt(6);
            m_item_target = (GComponent)GetChildComAt(7);
            m_txt_tip1 = (GTextField)GetChildAt(8);
            m_txt_tip2 = (GTextField)GetChildAt(9);
            m_txt_cost = (GRichTextField)GetChildAt(10);
            m_txt_decomposeCount = (GTextInput)GetChildAt(11);
            m_list_item = (GList)GetChildComAt(12);
            m_item_cost = (GComponent)GetChildComAt(13);
            m_btn_sub = (GButton)GetChildComAt(14);
            m_btn_add = (GButton)GetChildComAt(15);
            m_btn_slide = (GSlider)GetChildComAt(16);
            m_btn_cancel = (GButton)GetChildComAt(17);
            m_btn_decompose = (GButton)GetChildComAt(18);
        }
    }
}