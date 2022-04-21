/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GImage m_n82;
        public GComponent m_con_avatar;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GLoader m_img_quality;
        public GLoader m_img_awake;
        public GImage m_n75;
        public GRichTextField m_txt_name;
        public GButton m_btn_lock;
        public GList m_list_star;
        public GGroup m_gp_top;
        public GLoader m_img_center;
        public GImage m_img_power;
        public GImage m_n74;
        public GTextField m_txt_power;
        public GTextField m_txt_level;
        public UI_PetBaseSkin m_view_base;
        public UI_PetEquipSkin m_view_equip;
        public UI_PetStoneSkin m_view_stone;
        public GLoader m_img_element;
        public GLoader m_img_type;
        public GLoader m_img_equip;
        public GLoader m_img_bottom;
        public GButton m_btn_base;
        public GButton m_btn_equip;
        public GButton m_btn_stone;
        public GButton m_btn_wake;
        public GGroup m_gp_bottom;
        public GImage m_bg_bubble;
        public GRichTextField m_txt_bubble;
        public GGroup m_gp_bubble;
        public GButton m_btn_back;
        public const string URL = "ui://em095moert0b6";

        public static UI_PetSkin CreateInstance()
        {
            return (UI_PetSkin)UIPackage.CreateComponet("Pet", "PetSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_n82 = (GImage)GetChildAt(1);
            m_con_avatar = (GComponent)GetChildComAt(2);
            m_btn_left = (GButton)GetChildComAt(3);
            m_btn_right = (GButton)GetChildComAt(4);
            m_img_quality = (GLoader)GetChildAt(5);
            m_img_awake = (GLoader)GetChildAt(6);
            m_n75 = (GImage)GetChildAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
            m_btn_lock = (GButton)GetChildComAt(9);
            m_list_star = (GList)GetChildComAt(10);
            m_gp_top = (GGroup)GetChildAt(11);
            m_img_center = (GLoader)GetChildAt(12);
            m_img_power = (GImage)GetChildAt(13);
            m_n74 = (GImage)GetChildAt(14);
            m_txt_power = (GTextField)GetChildAt(15);
            m_txt_level = (GTextField)GetChildAt(16);
            m_view_base = (UI_PetBaseSkin)GetChildComAt(17);
            m_view_equip = (UI_PetEquipSkin)GetChildComAt(18);
            m_view_stone = (UI_PetStoneSkin)GetChildComAt(19);
            m_img_element = (GLoader)GetChildAt(20);
            m_img_type = (GLoader)GetChildAt(21);
            m_img_equip = (GLoader)GetChildAt(22);
            m_img_bottom = (GLoader)GetChildAt(23);
            m_btn_base = (GButton)GetChildComAt(24);
            m_btn_equip = (GButton)GetChildComAt(25);
            m_btn_stone = (GButton)GetChildComAt(26);
            m_btn_wake = (GButton)GetChildComAt(27);
            m_gp_bottom = (GGroup)GetChildAt(28);
            m_bg_bubble = (GImage)GetChildAt(29);
            m_txt_bubble = (GRichTextField)GetChildAt(30);
            m_gp_bubble = (GGroup)GetChildAt(31);
            m_btn_back = (GButton)GetChildComAt(32);
        }
    }
}