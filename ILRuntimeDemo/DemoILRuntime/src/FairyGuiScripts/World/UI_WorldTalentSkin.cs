/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldTalentSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GList m_list_tab;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GComponent m_currency_1;
        public GComponent m_currency_2;
        public UI_WorldTalentItemSkin m_item_1;
        public UI_WorldTalentItemSkin m_item_2;
        public UI_WorldTalentItemSkin m_item_3;
        public UI_WorldTalentItemSkin m_item_4;
        public UI_WorldTalentItemSkin m_item_5;
        public UI_WorldTalentItemSkin m_item_6;
        public UI_WorldTalentItemSkin m_item_7;
        public UI_WorldTalentItemSkin m_item_8;
        public UI_WorldTalentItemSkin m_item_9;
        public UI_WorldTalentItemSkin m_item_10;
        public UI_WorldTalentItemSkin m_item_11;
        public UI_WorldTalentItemSkin m_item_12;
        public UI_WorldTalentItemSkin m_item_13;
        public UI_WorldTalentItemSkin m_item_14;
        public UI_WorldTalentItemSkin m_item_15;
        public UI_WorldTalentItemSkin m_item_16;
        public UI_WorldTalentItemSkin m_item_17;
        public UI_WorldTalentItemSkin m_item_18;
        public UI_WorldTalentItemSkin m_item_19;
        public const string URL = "ui://63ubk2jodibi9";

        public static UI_WorldTalentSkin CreateInstance()
        {
            return (UI_WorldTalentSkin)UIPackage.CreateComponet("World", "WorldTalentSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_list_tab = (GList)GetChildComAt(2);
            m_btn_left = (GButton)GetChildComAt(3);
            m_btn_right = (GButton)GetChildComAt(4);
            m_currency_1 = (GComponent)GetChildComAt(5);
            m_currency_2 = (GComponent)GetChildComAt(6);
            m_item_1 = (UI_WorldTalentItemSkin)GetChildComAt(7);
            m_item_2 = (UI_WorldTalentItemSkin)GetChildComAt(8);
            m_item_3 = (UI_WorldTalentItemSkin)GetChildComAt(9);
            m_item_4 = (UI_WorldTalentItemSkin)GetChildComAt(10);
            m_item_5 = (UI_WorldTalentItemSkin)GetChildComAt(11);
            m_item_6 = (UI_WorldTalentItemSkin)GetChildComAt(12);
            m_item_7 = (UI_WorldTalentItemSkin)GetChildComAt(13);
            m_item_8 = (UI_WorldTalentItemSkin)GetChildComAt(14);
            m_item_9 = (UI_WorldTalentItemSkin)GetChildComAt(15);
            m_item_10 = (UI_WorldTalentItemSkin)GetChildComAt(16);
            m_item_11 = (UI_WorldTalentItemSkin)GetChildComAt(17);
            m_item_12 = (UI_WorldTalentItemSkin)GetChildComAt(18);
            m_item_13 = (UI_WorldTalentItemSkin)GetChildComAt(19);
            m_item_14 = (UI_WorldTalentItemSkin)GetChildComAt(20);
            m_item_15 = (UI_WorldTalentItemSkin)GetChildComAt(21);
            m_item_16 = (UI_WorldTalentItemSkin)GetChildComAt(22);
            m_item_17 = (UI_WorldTalentItemSkin)GetChildComAt(23);
            m_item_18 = (UI_WorldTalentItemSkin)GetChildComAt(24);
            m_item_19 = (UI_WorldTalentItemSkin)GetChildComAt(25);
        }
    }
}