/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_StoneComposeSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GImage m_n19;
        public GImage m_n22;
        public GTextField m_txt_tip1;
        public GTextField m_txt_noTips;
        public UI_StoneSlotSkin m_item_target;
        public UI_StoneSlotSkin m_item_add3;
        public UI_StoneSlotSkin m_item_add4;
        public UI_StoneSlotSkin m_item_add0;
        public UI_StoneSlotSkin m_item_add1;
        public UI_StoneSlotSkin m_item_add2;
        public GList m_list_item;
        public GButton m_btn_white;
        public GButton m_btn_black;
        public GButton m_btn_all;
        public GButton m_btn_filter;
        public GButton m_btn_compose;
        public GButton m_btn_addAll;
        public GGraph m_n25;
        public GGraph m_n27;
        public GGraph m_n28;
        public GButton m_btn_back;
        public GLabel m_title;
        public const string URL = "ui://em095moert0b13";

        public static UI_StoneComposeSkin CreateInstance()
        {
            return (UI_StoneComposeSkin)UIPackage.CreateComponet("Pet", "StoneComposeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_n19 = (GImage)GetChildAt(1);
            m_n22 = (GImage)GetChildAt(2);
            m_txt_tip1 = (GTextField)GetChildAt(3);
            m_txt_noTips = (GTextField)GetChildAt(4);
            m_item_target = (UI_StoneSlotSkin)GetChildComAt(5);
            m_item_add3 = (UI_StoneSlotSkin)GetChildComAt(6);
            m_item_add4 = (UI_StoneSlotSkin)GetChildComAt(7);
            m_item_add0 = (UI_StoneSlotSkin)GetChildComAt(8);
            m_item_add1 = (UI_StoneSlotSkin)GetChildComAt(9);
            m_item_add2 = (UI_StoneSlotSkin)GetChildComAt(10);
            m_list_item = (GList)GetChildComAt(11);
            m_btn_white = (GButton)GetChildComAt(12);
            m_btn_black = (GButton)GetChildComAt(13);
            m_btn_all = (GButton)GetChildComAt(14);
            m_btn_filter = (GButton)GetChildComAt(15);
            m_btn_compose = (GButton)GetChildComAt(16);
            m_btn_addAll = (GButton)GetChildComAt(17);
            m_n25 = (GGraph)GetChildAt(18);
            m_n27 = (GGraph)GetChildAt(19);
            m_n28 = (GGraph)GetChildAt(20);
            m_btn_back = (GButton)GetChildComAt(21);
            m_title = (GLabel)GetChildComAt(22);
        }
    }
}