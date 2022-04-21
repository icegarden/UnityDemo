/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HallViewSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GComponent m_n22;
        public UI_FoundationSmallItem1Skin m_slot_1;
        public UI_FoundationSmallItem1Skin m_slot_2;
        public UI_FoundationSmallItem0Skin m_slot_3;
        public UI_FoundationSmallItem1Skin m_slot_4;
        public UI_FoundationSmallItem1Skin m_slot_5;
        public UI_FoundationSmallItem0Skin m_slot_6;
        public UI_FoundationSmallItem2Skin m_slot_7;
        public UI_FoundationSmallItem0Skin m_slot_8;
        public UI_FoundationSmallItem0Skin m_slot_9;
        public UI_FoundationSmallItem1Skin m_slot_10;
        public UI_FoundationSmallItem1Skin m_slot_11;
        public UI_FoundationSmallItem0Skin m_slot_12;
        public GButton m_btn_large;
        public GButton m_btn_middle;
        public GButton m_btn_small;
        public GList m_list_item;
        public GImage m_n23;
        public GGraph m_n25;
        public const string URL = "ui://wua6gzxlikzm1u";

        public static UI_HallViewSkin CreateInstance()
        {
            return (UI_HallViewSkin)UIPackage.CreateComponet("Home", "HallViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_n22 = (GComponent)GetChildComAt(1);
            m_slot_1 = (UI_FoundationSmallItem1Skin)GetChildComAt(2);
            m_slot_2 = (UI_FoundationSmallItem1Skin)GetChildComAt(3);
            m_slot_3 = (UI_FoundationSmallItem0Skin)GetChildComAt(4);
            m_slot_4 = (UI_FoundationSmallItem1Skin)GetChildComAt(5);
            m_slot_5 = (UI_FoundationSmallItem1Skin)GetChildComAt(6);
            m_slot_6 = (UI_FoundationSmallItem0Skin)GetChildComAt(7);
            m_slot_7 = (UI_FoundationSmallItem2Skin)GetChildComAt(8);
            m_slot_8 = (UI_FoundationSmallItem0Skin)GetChildComAt(9);
            m_slot_9 = (UI_FoundationSmallItem0Skin)GetChildComAt(10);
            m_slot_10 = (UI_FoundationSmallItem1Skin)GetChildComAt(11);
            m_slot_11 = (UI_FoundationSmallItem1Skin)GetChildComAt(12);
            m_slot_12 = (UI_FoundationSmallItem0Skin)GetChildComAt(13);
            m_btn_large = (GButton)GetChildComAt(14);
            m_btn_middle = (GButton)GetChildComAt(15);
            m_btn_small = (GButton)GetChildComAt(16);
            m_list_item = (GList)GetChildComAt(17);
            m_n23 = (GImage)GetChildAt(18);
            m_n25 = (GGraph)GetChildAt(19);
        }
    }
}