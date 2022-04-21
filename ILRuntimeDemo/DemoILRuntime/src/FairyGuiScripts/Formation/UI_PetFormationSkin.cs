/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Formation
{
    public partial class UI_PetFormationSkin : GComponent
    {
        public Controller m_tab;
        public Controller m_state;
        public GLoader m_bg;
        public GLoader m_img_bg1;
        public GLoader m_img_bg2;
        public GLoader m_img_middle;
        public GLabel m_title;
        public GImage m_n108;
        public GImage m_n72;
        public GImage m_bg_enemyCount;
        public GImage m_n106;
        public GImage m_n107;
        public GImage m_n110;
        public GImage m_n111;
        public GTextField m_txt_power;
        public GTextField m_txt_enemyPower;
        public GRichTextField m_txt_count;
        public GRichTextField m_txt_enemyCount;
        public GButton m_btn_use;
        public GButton m_btn_onekey;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GList m_list_pet;
        public UI_PetFormationFightItemSkin m_self_6;
        public UI_PetFormationFightItemSkin m_self_7;
        public UI_PetFormationFightItemSkin m_self_8;
        public UI_PetFormationFightItemSkin m_self_9;
        public UI_PetFormationFightItemSkin m_self_10;
        public UI_PetFormationFightItemSkin m_self_1;
        public UI_PetFormationFightItemSkin m_self_2;
        public UI_PetFormationFightItemSkin m_self_3;
        public UI_PetFormationFightItemSkin m_self_4;
        public UI_PetFormationFightItemSkin m_self_5;
        public UI_PetFormationFightItemSkin m_enemy_6;
        public UI_PetFormationFightItemSkin m_enemy_7;
        public UI_PetFormationFightItemSkin m_enemy_8;
        public UI_PetFormationFightItemSkin m_enemy_9;
        public UI_PetFormationFightItemSkin m_enemy_10;
        public UI_PetFormationFightItemSkin m_enemy_1;
        public UI_PetFormationFightItemSkin m_enemy_2;
        public UI_PetFormationFightItemSkin m_enemy_3;
        public UI_PetFormationFightItemSkin m_enemy_4;
        public UI_PetFormationFightItemSkin m_enemy_5;
        public GGroup m_gp_enemy;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public const string URL = "ui://6c5g9rs5pav81c";

        public static UI_PetFormationSkin CreateInstance()
        {
            return (UI_PetFormationSkin)UIPackage.CreateComponet("Formation", "PetFormationSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_img_bg2 = (GLoader)GetChildAt(2);
            m_img_middle = (GLoader)GetChildAt(3);
            m_title = (GLabel)GetChildComAt(4);
            m_n108 = (GImage)GetChildAt(5);
            m_n72 = (GImage)GetChildAt(6);
            m_bg_enemyCount = (GImage)GetChildAt(7);
            m_n106 = (GImage)GetChildAt(8);
            m_n107 = (GImage)GetChildAt(9);
            m_n110 = (GImage)GetChildAt(10);
            m_n111 = (GImage)GetChildAt(11);
            m_txt_power = (GTextField)GetChildAt(12);
            m_txt_enemyPower = (GTextField)GetChildAt(13);
            m_txt_count = (GRichTextField)GetChildAt(14);
            m_txt_enemyCount = (GRichTextField)GetChildAt(15);
            m_btn_use = (GButton)GetChildComAt(16);
            m_btn_onekey = (GButton)GetChildComAt(17);
            m_btn_tab0 = (GButton)GetChildComAt(18);
            m_btn_tab1 = (GButton)GetChildComAt(19);
            m_btn_tab2 = (GButton)GetChildComAt(20);
            m_btn_tab3 = (GButton)GetChildComAt(21);
            m_btn_tab4 = (GButton)GetChildComAt(22);
            m_btn_tab5 = (GButton)GetChildComAt(23);
            m_btn_tab6 = (GButton)GetChildComAt(24);
            m_list_pet = (GList)GetChildComAt(25);
            m_self_6 = (UI_PetFormationFightItemSkin)GetChildComAt(26);
            m_self_7 = (UI_PetFormationFightItemSkin)GetChildComAt(27);
            m_self_8 = (UI_PetFormationFightItemSkin)GetChildComAt(28);
            m_self_9 = (UI_PetFormationFightItemSkin)GetChildComAt(29);
            m_self_10 = (UI_PetFormationFightItemSkin)GetChildComAt(30);
            m_self_1 = (UI_PetFormationFightItemSkin)GetChildComAt(31);
            m_self_2 = (UI_PetFormationFightItemSkin)GetChildComAt(32);
            m_self_3 = (UI_PetFormationFightItemSkin)GetChildComAt(33);
            m_self_4 = (UI_PetFormationFightItemSkin)GetChildComAt(34);
            m_self_5 = (UI_PetFormationFightItemSkin)GetChildComAt(35);
            m_enemy_6 = (UI_PetFormationFightItemSkin)GetChildComAt(36);
            m_enemy_7 = (UI_PetFormationFightItemSkin)GetChildComAt(37);
            m_enemy_8 = (UI_PetFormationFightItemSkin)GetChildComAt(38);
            m_enemy_9 = (UI_PetFormationFightItemSkin)GetChildComAt(39);
            m_enemy_10 = (UI_PetFormationFightItemSkin)GetChildComAt(40);
            m_enemy_1 = (UI_PetFormationFightItemSkin)GetChildComAt(41);
            m_enemy_2 = (UI_PetFormationFightItemSkin)GetChildComAt(42);
            m_enemy_3 = (UI_PetFormationFightItemSkin)GetChildComAt(43);
            m_enemy_4 = (UI_PetFormationFightItemSkin)GetChildComAt(44);
            m_enemy_5 = (UI_PetFormationFightItemSkin)GetChildComAt(45);
            m_gp_enemy = (GGroup)GetChildAt(46);
            m_img_bottom = (GLoader)GetChildAt(47);
            m_btn_back = (GButton)GetChildComAt(48);
        }
    }
}