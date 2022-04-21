/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomUpgradeSkin : GComponent
    {
        public Controller m_type;
        public Controller m_state;
        public Controller m_passiveType;
        public GLabel m_bg;
        public GComponent m_item;
        public GComponent m_star1;
        public GComponent m_star2;
        public GComponent m_star3;
        public GComponent m_star4;
        public GComponent m_star5;
        public GImage m_n41;
        public GImage m_n42;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_star;
        public GRichTextField m_txt_effectDesc;
        public GRichTextField m_txt_effectCount;
        public GRichTextField m_txt_totalEffect;
        public GTextField m_txt_full;
        public GList m_list_baseAttr;
        public GList m_list_passiveAttr;
        public GList m_list_cost;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_upgrade;
        public GButton m_btn_upstar;
        public GImage m_n49;
        public GTextField m_txt_tip3;
        public GButton m_btn_pet;
        public const string URL = "ui://rqnkl6749hynw";

        public static UI_HalidomUpgradeSkin CreateInstance()
        {
            return (UI_HalidomUpgradeSkin)UIPackage.CreateComponet("Halidom", "HalidomUpgradeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_passiveType = GetControllerAt(2);
            m_bg = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_star1 = (GComponent)GetChildComAt(2);
            m_star2 = (GComponent)GetChildComAt(3);
            m_star3 = (GComponent)GetChildComAt(4);
            m_star4 = (GComponent)GetChildComAt(5);
            m_star5 = (GComponent)GetChildComAt(6);
            m_n41 = (GImage)GetChildAt(7);
            m_n42 = (GImage)GetChildAt(8);
            m_txt_tip1 = (GTextField)GetChildAt(9);
            m_txt_tip2 = (GTextField)GetChildAt(10);
            m_txt_name = (GRichTextField)GetChildAt(11);
            m_txt_level = (GTextField)GetChildAt(12);
            m_txt_star = (GTextField)GetChildAt(13);
            m_txt_effectDesc = (GRichTextField)GetChildAt(14);
            m_txt_effectCount = (GRichTextField)GetChildAt(15);
            m_txt_totalEffect = (GRichTextField)GetChildAt(16);
            m_txt_full = (GTextField)GetChildAt(17);
            m_list_baseAttr = (GList)GetChildComAt(18);
            m_list_passiveAttr = (GList)GetChildComAt(19);
            m_list_cost = (GList)GetChildComAt(20);
            m_btn_left = (GButton)GetChildComAt(21);
            m_btn_right = (GButton)GetChildComAt(22);
            m_btn_upgrade = (GButton)GetChildComAt(23);
            m_btn_upstar = (GButton)GetChildComAt(24);
            m_n49 = (GImage)GetChildAt(25);
            m_txt_tip3 = (GTextField)GetChildAt(26);
            m_btn_pet = (GButton)GetChildComAt(27);
        }
    }
}