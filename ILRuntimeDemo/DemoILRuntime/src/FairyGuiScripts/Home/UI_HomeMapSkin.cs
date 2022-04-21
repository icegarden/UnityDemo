/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HomeMapSkin : GComponent
    {
        public GLoader m_bg;
        public GButton m_btn_camp;
        public UI_FoundationItem1Skin m_slot_1;
        public UI_FoundationItem1Skin m_slot_2;
        public UI_FoundationItem0Skin m_slot_3;
        public UI_FoundationItem1Skin m_slot_4;
        public UI_FoundationItem1Skin m_slot_5;
        public UI_FoundationItem0Skin m_slot_6;
        public UI_FoundationItem2Skin m_slot_7;
        public UI_FoundationItem0Skin m_slot_8;
        public UI_FoundationItem0Skin m_slot_9;
        public UI_FoundationItem1Skin m_slot_10;
        public UI_FoundationItem1Skin m_slot_11;
        public UI_FoundationItem0Skin m_slot_12;
        public GButton m_btn_farm;
        public GImage m_n19;
        public GTextField m_txt_farm;
        public const string URL = "ui://wua6gzxlxxxi2a";

        public static UI_HomeMapSkin CreateInstance()
        {
            return (UI_HomeMapSkin)UIPackage.CreateComponet("Home", "HomeMapSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_btn_camp = (GButton)GetChildComAt(1);
            m_slot_1 = (UI_FoundationItem1Skin)GetChildComAt(2);
            m_slot_2 = (UI_FoundationItem1Skin)GetChildComAt(3);
            m_slot_3 = (UI_FoundationItem0Skin)GetChildComAt(4);
            m_slot_4 = (UI_FoundationItem1Skin)GetChildComAt(5);
            m_slot_5 = (UI_FoundationItem1Skin)GetChildComAt(6);
            m_slot_6 = (UI_FoundationItem0Skin)GetChildComAt(7);
            m_slot_7 = (UI_FoundationItem2Skin)GetChildComAt(8);
            m_slot_8 = (UI_FoundationItem0Skin)GetChildComAt(9);
            m_slot_9 = (UI_FoundationItem0Skin)GetChildComAt(10);
            m_slot_10 = (UI_FoundationItem1Skin)GetChildComAt(11);
            m_slot_11 = (UI_FoundationItem1Skin)GetChildComAt(12);
            m_slot_12 = (UI_FoundationItem0Skin)GetChildComAt(13);
            m_btn_farm = (GButton)GetChildComAt(14);
            m_n19 = (GImage)GetChildAt(15);
            m_txt_farm = (GTextField)GetChildAt(16);
        }
    }
}