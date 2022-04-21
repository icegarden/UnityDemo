/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipIdentifySkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_img_bottom;
        public GLoader m_img_icon;
        public GLabel m_title;
        public GImage m_n3;
        public GTextField m_txt_level;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_special;
        public GTextField m_txt_empty;
        public GProgressBar m_pb_exp;
        public GList m_list_quality;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_select;
        public GButton m_btn_back;
        public UI_IdentifyCostItem1Skin m_item_cost0;
        public UI_IdentifyCostItem1Skin m_item_cost1;
        public UI_IdentifyCostItem2Skin m_item_specialCost1;
        public UI_IdentifyCostItem2Skin m_item_specialCost2;
        public UI_IdentifyCostItem2Skin m_item_specialCost3;
        public GButton m_btn_identify;
        public const string URL = "ui://5ch1xwvwl1me30";

        public static UI_EquipIdentifySkin CreateInstance()
        {
            return (UI_EquipIdentifySkin)UIPackage.CreateComponet("Equip", "EquipIdentifySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_title = (GLabel)GetChildComAt(3);
            m_n3 = (GImage)GetChildAt(4);
            m_txt_level = (GTextField)GetChildAt(5);
            m_txt_tip1 = (GTextField)GetChildAt(6);
            m_txt_tip2 = (GTextField)GetChildAt(7);
            m_txt_tip3 = (GTextField)GetChildAt(8);
            m_txt_special = (GTextField)GetChildAt(9);
            m_txt_empty = (GTextField)GetChildAt(10);
            m_pb_exp = (GProgressBar)GetChildComAt(11);
            m_list_quality = (GList)GetChildComAt(12);
            m_btn_left = (GButton)GetChildComAt(13);
            m_btn_right = (GButton)GetChildComAt(14);
            m_btn_select = (GButton)GetChildComAt(15);
            m_btn_back = (GButton)GetChildComAt(16);
            m_item_cost0 = (UI_IdentifyCostItem1Skin)GetChildComAt(17);
            m_item_cost1 = (UI_IdentifyCostItem1Skin)GetChildComAt(18);
            m_item_specialCost1 = (UI_IdentifyCostItem2Skin)GetChildComAt(19);
            m_item_specialCost2 = (UI_IdentifyCostItem2Skin)GetChildComAt(20);
            m_item_specialCost3 = (UI_IdentifyCostItem2Skin)GetChildComAt(21);
            m_btn_identify = (GButton)GetChildComAt(22);
        }
    }
}