/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_RecommendStoneCombineSkin : GComponent
    {
        public Controller m_tab;
        public GLabel m_bg;
        public GLoader m_img_bg;
        public GImage m_n23;
        public GImage m_n25;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip1;
        public GList m_list_name;
        public GList m_list_item;
        public UI_PetStoneSlotSkin m_slot0;
        public UI_PetStoneSlotSkin m_slot1;
        public UI_PetStoneSlotSkin m_slot2;
        public UI_PetStoneSlotSkin m_slot3;
        public UI_PetStoneSlotSkin m_slot4;
        public UI_PetStoneSlotSkin m_slot5;
        public UI_PetStoneSlotSkin m_slot6;
        public UI_PetStoneSlotSkin m_slot7;
        public GButton m_btn_remove;
        public GButton m_btn_confime;
        public GButton m_btn_ignore;
        public GButton m_btn_common;
        public GButton m_btn_exclusive;
        public GComponent m_btn_close;
        public GGraph m_n30;
        public GGraph m_n31;
        public GGroup m_n34;
        public const string URL = "ui://em095moert0b1b";

        public static UI_RecommendStoneCombineSkin CreateInstance()
        {
            return (UI_RecommendStoneCombineSkin)UIPackage.CreateComponet("Pet", "RecommendStoneCombineSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_n23 = (GImage)GetChildAt(2);
            m_n25 = (GImage)GetChildAt(3);
            m_txt_tip2 = (GTextField)GetChildAt(4);
            m_txt_tip1 = (GTextField)GetChildAt(5);
            m_list_name = (GList)GetChildComAt(6);
            m_list_item = (GList)GetChildComAt(7);
            m_slot0 = (UI_PetStoneSlotSkin)GetChildComAt(8);
            m_slot1 = (UI_PetStoneSlotSkin)GetChildComAt(9);
            m_slot2 = (UI_PetStoneSlotSkin)GetChildComAt(10);
            m_slot3 = (UI_PetStoneSlotSkin)GetChildComAt(11);
            m_slot4 = (UI_PetStoneSlotSkin)GetChildComAt(12);
            m_slot5 = (UI_PetStoneSlotSkin)GetChildComAt(13);
            m_slot6 = (UI_PetStoneSlotSkin)GetChildComAt(14);
            m_slot7 = (UI_PetStoneSlotSkin)GetChildComAt(15);
            m_btn_remove = (GButton)GetChildComAt(16);
            m_btn_confime = (GButton)GetChildComAt(17);
            m_btn_ignore = (GButton)GetChildComAt(18);
            m_btn_common = (GButton)GetChildComAt(19);
            m_btn_exclusive = (GButton)GetChildComAt(20);
            m_btn_close = (GComponent)GetChildComAt(21);
            m_n30 = (GGraph)GetChildAt(22);
            m_n31 = (GGraph)GetChildAt(23);
            m_n34 = (GGroup)GetChildAt(24);
        }
    }
}