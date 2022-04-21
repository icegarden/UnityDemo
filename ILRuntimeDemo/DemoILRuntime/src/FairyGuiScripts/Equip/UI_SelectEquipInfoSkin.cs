/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_SelectEquipInfoSkin : GComponent
    {
        public Controller m_type;
        public Controller m_state;
        public GImage m_bg;
        public GImage m_n60;
        public GImage m_n61;
        public GImage m_n66;
        public GImage m_n67;
        public GComponent m_item;
        public GImage m_img_bosstab;
        public GImage m_img_suittab;
        public GImage m_img_equiped;
        public GRichTextField m_txt_name;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_part;
        public GTextField m_txt_level;
        public GTextField m_txt_baseTitle;
        public GTextField m_txt_suffixTitle;
        public GList m_list_baseAttr;
        public GList m_list_extraAttr;
        public GButton m_btn_lock;
        public GButton m_btn_refine;
        public GButton m_btn_remove;
        public GButton m_btn_replace;
        public GButton m_btn_equip;
        public GImage m_n62;
        public GImage m_n68;
        public GTextField m_txt_skillTitle;
        public GList m_list_skill;
        public GGroup m_gp_skill;
        public GImage m_n70;
        public GImage m_n69;
        public GImage m_n72;
        public GRichTextField m_txt_suitName;
        public GTextField m_txt_suitTitle;
        public GList m_list_suit;
        public GGroup m_gp_suit;
        public const string URL = "ui://5ch1xwvwsig293";

        public static UI_SelectEquipInfoSkin CreateInstance()
        {
            return (UI_SelectEquipInfoSkin)UIPackage.CreateComponet("Equip", "SelectEquipInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_bg = (GImage)GetChildAt(0);
            m_n60 = (GImage)GetChildAt(1);
            m_n61 = (GImage)GetChildAt(2);
            m_n66 = (GImage)GetChildAt(3);
            m_n67 = (GImage)GetChildAt(4);
            m_item = (GComponent)GetChildComAt(5);
            m_img_bosstab = (GImage)GetChildAt(6);
            m_img_suittab = (GImage)GetChildAt(7);
            m_img_equiped = (GImage)GetChildAt(8);
            m_txt_name = (GRichTextField)GetChildAt(9);
            m_txt_power = (GTextField)GetChildAt(10);
            m_txt_type = (GTextField)GetChildAt(11);
            m_txt_part = (GTextField)GetChildAt(12);
            m_txt_level = (GTextField)GetChildAt(13);
            m_txt_baseTitle = (GTextField)GetChildAt(14);
            m_txt_suffixTitle = (GTextField)GetChildAt(15);
            m_list_baseAttr = (GList)GetChildComAt(16);
            m_list_extraAttr = (GList)GetChildComAt(17);
            m_btn_lock = (GButton)GetChildComAt(18);
            m_btn_refine = (GButton)GetChildComAt(19);
            m_btn_remove = (GButton)GetChildComAt(20);
            m_btn_replace = (GButton)GetChildComAt(21);
            m_btn_equip = (GButton)GetChildComAt(22);
            m_n62 = (GImage)GetChildAt(23);
            m_n68 = (GImage)GetChildAt(24);
            m_txt_skillTitle = (GTextField)GetChildAt(25);
            m_list_skill = (GList)GetChildComAt(26);
            m_gp_skill = (GGroup)GetChildAt(27);
            m_n70 = (GImage)GetChildAt(28);
            m_n69 = (GImage)GetChildAt(29);
            m_n72 = (GImage)GetChildAt(30);
            m_txt_suitName = (GRichTextField)GetChildAt(31);
            m_txt_suitTitle = (GTextField)GetChildAt(32);
            m_list_suit = (GList)GetChildComAt(33);
            m_gp_suit = (GGroup)GetChildAt(34);
        }
    }
}