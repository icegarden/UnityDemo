/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomInfoSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GImage m_n48;
        public GComponent m_item;
        public GTextField m_txt_level;
        public GTextField m_txt_star;
        public GTextField m_txt_power;
        public GRichTextField m_txt_name;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_upstar;
        public GButton m_btn_upgrade;
        public GButton m_btn_get;
        public GComponent m_star1;
        public GComponent m_star2;
        public GComponent m_star3;
        public GComponent m_star4;
        public GComponent m_star5;
        public GImage m_n49;
        public GImage m_n50;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GRichTextField m_txt_effectDesc;
        public GTextField m_txt_effectCount;
        public GTextField m_txt_totalEffect;
        public GList m_list_baseAttr;
        public GList m_list_passiveAttr;
        public GButton m_btn_pet;
        public GImage m_n57;
        public GTextField m_txt_tip4;
        public GRichTextField m_txt_suitName;
        public GRichTextField m_txt_suitDesc;
        public GGroup m_gp_suit;
        public const string URL = "ui://rqnkl6749hynu";

        public static UI_HalidomInfoSkin CreateInstance()
        {
            return (UI_HalidomInfoSkin)UIPackage.CreateComponet("Halidom", "HalidomInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n48 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_txt_level = (GTextField)GetChildAt(3);
            m_txt_star = (GTextField)GetChildAt(4);
            m_txt_power = (GTextField)GetChildAt(5);
            m_txt_name = (GRichTextField)GetChildAt(6);
            m_btn_left = (GButton)GetChildComAt(7);
            m_btn_right = (GButton)GetChildComAt(8);
            m_btn_upstar = (GButton)GetChildComAt(9);
            m_btn_upgrade = (GButton)GetChildComAt(10);
            m_btn_get = (GButton)GetChildComAt(11);
            m_star1 = (GComponent)GetChildComAt(12);
            m_star2 = (GComponent)GetChildComAt(13);
            m_star3 = (GComponent)GetChildComAt(14);
            m_star4 = (GComponent)GetChildComAt(15);
            m_star5 = (GComponent)GetChildComAt(16);
            m_n49 = (GImage)GetChildAt(17);
            m_n50 = (GImage)GetChildAt(18);
            m_txt_tip1 = (GTextField)GetChildAt(19);
            m_txt_tip2 = (GTextField)GetChildAt(20);
            m_txt_tip3 = (GTextField)GetChildAt(21);
            m_txt_effectDesc = (GRichTextField)GetChildAt(22);
            m_txt_effectCount = (GTextField)GetChildAt(23);
            m_txt_totalEffect = (GTextField)GetChildAt(24);
            m_list_baseAttr = (GList)GetChildComAt(25);
            m_list_passiveAttr = (GList)GetChildComAt(26);
            m_btn_pet = (GButton)GetChildComAt(27);
            m_n57 = (GImage)GetChildAt(28);
            m_txt_tip4 = (GTextField)GetChildAt(29);
            m_txt_suitName = (GRichTextField)GetChildAt(30);
            m_txt_suitDesc = (GRichTextField)GetChildAt(31);
            m_gp_suit = (GGroup)GetChildAt(32);
        }
    }
}