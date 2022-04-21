/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_EquipTipsViewSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GImage m_n60;
        public GImage m_n61;
        public GImage m_n62;
        public GImage m_img_bosstab;
        public GImage m_img_suittab;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_suitName;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_level;
        public GTextField m_txt_baseTitle;
        public GTextField m_txt_suffixTitle;
        public GTextField m_txt_skillTitle;
        public GTextField m_txt_suitTitle;
        public GTextField m_txt_suffix;
        public GList m_list_baseAttr;
        public GList m_list_extraAttr;
        public GList m_list_skill;
        public GList m_list_suit;
        public GButton m_btn_share;
        public GButton m_btn_lock;
        public GButton m_btn_refine;
        public GButton m_btn_identify;
        public GButton m_btn_get;
        public GTextField m_txt_part;
        public const string URL = "ui://e98lwrloh7464b";

        public static UI_EquipTipsViewSkin CreateInstance()
        {
            return (UI_EquipTipsViewSkin)UIPackage.CreateComponet("Bag", "EquipTipsViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n60 = (GImage)GetChildAt(1);
            m_n61 = (GImage)GetChildAt(2);
            m_n62 = (GImage)GetChildAt(3);
            m_img_bosstab = (GImage)GetChildAt(4);
            m_img_suittab = (GImage)GetChildAt(5);
            m_item = (GComponent)GetChildComAt(6);
            m_txt_name = (GRichTextField)GetChildAt(7);
            m_txt_suitName = (GRichTextField)GetChildAt(8);
            m_txt_power = (GTextField)GetChildAt(9);
            m_txt_type = (GTextField)GetChildAt(10);
            m_txt_level = (GTextField)GetChildAt(11);
            m_txt_baseTitle = (GTextField)GetChildAt(12);
            m_txt_suffixTitle = (GTextField)GetChildAt(13);
            m_txt_skillTitle = (GTextField)GetChildAt(14);
            m_txt_suitTitle = (GTextField)GetChildAt(15);
            m_txt_suffix = (GTextField)GetChildAt(16);
            m_list_baseAttr = (GList)GetChildComAt(17);
            m_list_extraAttr = (GList)GetChildComAt(18);
            m_list_skill = (GList)GetChildComAt(19);
            m_list_suit = (GList)GetChildComAt(20);
            m_btn_share = (GButton)GetChildComAt(21);
            m_btn_lock = (GButton)GetChildComAt(22);
            m_btn_refine = (GButton)GetChildComAt(23);
            m_btn_identify = (GButton)GetChildComAt(24);
            m_btn_get = (GButton)GetChildComAt(25);
            m_txt_part = (GTextField)GetChildAt(26);
        }
    }
}