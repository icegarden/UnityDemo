/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GComponent m_con_avatar;
        public UI_EquipSlotSkin m_slot_1;
        public UI_EquipSlotSkin m_slot_2;
        public UI_EquipSlotSkin m_slot_3;
        public UI_EquipSlotSkin m_slot_4;
        public UI_EquipSlotSkin m_slot_5;
        public UI_EquipSlotSkin m_slot_6;
        public UI_EquipSlotSkin m_slot_7;
        public UI_EquipSlotSkin m_slot_8;
        public UI_SkillIconSkin m_skill_0;
        public UI_SkillIconSkin m_skill_1;
        public UI_SkillIconSkin m_skill_2;
        public UI_SkillIconSkin m_skill_3;
        public GComponent m_bg_info;
        public GImage m_n30;
        public GImage m_n31;
        public GTextField m_txt_tip1;
        public GTextField m_txt_level;
        public GList m_list_attr;
        public GList m_list_cost;
        public GButton m_btn_artifact;
        public GButton m_btn_upgrade;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_attr;
        public GButton m_btn_remove;
        public GButton m_btn_equip;
        public GButton m_btn_upstar;
        public GButton m_btn_special;
        public GGroup m_n43;
        public GLabel m_title;
        public GImage m_n54;
        public GImage m_n44;
        public GImage m_n45;
        public GTextField m_txt_power;
        public GButton m_btn_back;
        public GButton m_btn_role;
        public GButton m_btn_skill;
        public GList m_list_star;
        public const string URL = "ui://edfpwlj6pcju0";

        public static UI_RoleSkin CreateInstance()
        {
            return (UI_RoleSkin)UIPackage.CreateComponet("Role", "RoleSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_con_avatar = (GComponent)GetChildComAt(1);
            m_slot_1 = (UI_EquipSlotSkin)GetChildComAt(2);
            m_slot_2 = (UI_EquipSlotSkin)GetChildComAt(3);
            m_slot_3 = (UI_EquipSlotSkin)GetChildComAt(4);
            m_slot_4 = (UI_EquipSlotSkin)GetChildComAt(5);
            m_slot_5 = (UI_EquipSlotSkin)GetChildComAt(6);
            m_slot_6 = (UI_EquipSlotSkin)GetChildComAt(7);
            m_slot_7 = (UI_EquipSlotSkin)GetChildComAt(8);
            m_slot_8 = (UI_EquipSlotSkin)GetChildComAt(9);
            m_skill_0 = (UI_SkillIconSkin)GetChildComAt(10);
            m_skill_1 = (UI_SkillIconSkin)GetChildComAt(11);
            m_skill_2 = (UI_SkillIconSkin)GetChildComAt(12);
            m_skill_3 = (UI_SkillIconSkin)GetChildComAt(13);
            m_bg_info = (GComponent)GetChildComAt(14);
            m_n30 = (GImage)GetChildAt(15);
            m_n31 = (GImage)GetChildAt(16);
            m_txt_tip1 = (GTextField)GetChildAt(17);
            m_txt_level = (GTextField)GetChildAt(18);
            m_list_attr = (GList)GetChildComAt(19);
            m_list_cost = (GList)GetChildComAt(20);
            m_btn_artifact = (GButton)GetChildComAt(21);
            m_btn_upgrade = (GButton)GetChildComAt(22);
            m_btn_left = (GButton)GetChildComAt(23);
            m_btn_right = (GButton)GetChildComAt(24);
            m_btn_attr = (GButton)GetChildComAt(25);
            m_btn_remove = (GButton)GetChildComAt(26);
            m_btn_equip = (GButton)GetChildComAt(27);
            m_btn_upstar = (GButton)GetChildComAt(28);
            m_btn_special = (GButton)GetChildComAt(29);
            m_n43 = (GGroup)GetChildAt(30);
            m_title = (GLabel)GetChildComAt(31);
            m_n54 = (GImage)GetChildAt(32);
            m_n44 = (GImage)GetChildAt(33);
            m_n45 = (GImage)GetChildAt(34);
            m_txt_power = (GTextField)GetChildAt(35);
            m_btn_back = (GButton)GetChildComAt(36);
            m_btn_role = (GButton)GetChildComAt(37);
            m_btn_skill = (GButton)GetChildComAt(38);
            m_list_star = (GList)GetChildComAt(39);
        }
    }
}