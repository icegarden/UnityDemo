/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetExclusiveEquipSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n11;
        public GImage m_n12;
        public GLoader m_img_center;
        public GComponent m_item;
        public GImage m_n5;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_score;
        public GTextField m_txt_pet;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_tip1;
        public GTextField m_txt_skillName;
        public GRichTextField m_txt_skillDesc;
        public GTextField m_txt_max;
        public GComponent m_icon_skill;
        public GList m_list_item;
        public GList m_list_attr;
        public GButton m_btn_upgrade;
        public const string URL = "ui://em095moesig22";

        public static UI_PetExclusiveEquipSkin CreateInstance()
        {
            return (UI_PetExclusiveEquipSkin)UIPackage.CreateComponet("Pet", "PetExclusiveEquipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n11 = (GImage)GetChildAt(1);
            m_n12 = (GImage)GetChildAt(2);
            m_img_center = (GLoader)GetChildAt(3);
            m_item = (GComponent)GetChildComAt(4);
            m_n5 = (GImage)GetChildAt(5);
            m_txt_name = (GTextField)GetChildAt(6);
            m_txt_level = (GTextField)GetChildAt(7);
            m_txt_score = (GTextField)GetChildAt(8);
            m_txt_pet = (GTextField)GetChildAt(9);
            m_txt_desc = (GRichTextField)GetChildAt(10);
            m_txt_tip1 = (GTextField)GetChildAt(11);
            m_txt_skillName = (GTextField)GetChildAt(12);
            m_txt_skillDesc = (GRichTextField)GetChildAt(13);
            m_txt_max = (GTextField)GetChildAt(14);
            m_icon_skill = (GComponent)GetChildComAt(15);
            m_list_item = (GList)GetChildComAt(16);
            m_list_attr = (GList)GetChildComAt(17);
            m_btn_upgrade = (GButton)GetChildComAt(18);
        }
    }
}