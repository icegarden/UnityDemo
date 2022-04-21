/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleEquipTipsSkin : GComponent
    {
        public Controller m_type;
        public GImage m_bg;
        public GImage m_n27;
        public GGraph m_n28;
        public GImage m_n30;
        public GGraph m_n31;
        public GImage m_n41;
        public GGraph m_n42;
        public GImage m_n45;
        public GGraph m_n46;
        public GComponent m_item;
        public GTextField m_txt_level;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_tip4;
        public GTextField m_txt_equip;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_suitName;
        public GTextField m_txt_suffix;
        public GList m_list_baseAttr;
        public GList m_list_extraAttr;
        public GList m_list_skill;
        public GList m_list_suit;
        public GButton m_btn_equip;
        public const string URL = "ui://edfpwlj6rb8829";

        public static UI_RoleEquipTipsSkin CreateInstance()
        {
            return (UI_RoleEquipTipsSkin)UIPackage.CreateComponet("Role", "RoleEquipTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GImage)GetChildAt(0);
            m_n27 = (GImage)GetChildAt(1);
            m_n28 = (GGraph)GetChildAt(2);
            m_n30 = (GImage)GetChildAt(3);
            m_n31 = (GGraph)GetChildAt(4);
            m_n41 = (GImage)GetChildAt(5);
            m_n42 = (GGraph)GetChildAt(6);
            m_n45 = (GImage)GetChildAt(7);
            m_n46 = (GGraph)GetChildAt(8);
            m_item = (GComponent)GetChildComAt(9);
            m_txt_level = (GTextField)GetChildAt(10);
            m_txt_power = (GTextField)GetChildAt(11);
            m_txt_type = (GTextField)GetChildAt(12);
            m_txt_tip1 = (GTextField)GetChildAt(13);
            m_txt_tip2 = (GTextField)GetChildAt(14);
            m_txt_tip3 = (GTextField)GetChildAt(15);
            m_txt_tip4 = (GTextField)GetChildAt(16);
            m_txt_equip = (GTextField)GetChildAt(17);
            m_txt_name = (GRichTextField)GetChildAt(18);
            m_txt_suitName = (GRichTextField)GetChildAt(19);
            m_txt_suffix = (GTextField)GetChildAt(20);
            m_list_baseAttr = (GList)GetChildComAt(21);
            m_list_extraAttr = (GList)GetChildComAt(22);
            m_list_skill = (GList)GetChildComAt(23);
            m_list_suit = (GList)GetChildComAt(24);
            m_btn_equip = (GButton)GetChildComAt(25);
        }
    }
}