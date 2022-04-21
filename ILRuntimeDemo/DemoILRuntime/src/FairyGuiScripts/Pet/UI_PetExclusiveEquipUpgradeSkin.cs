/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetExclusiveEquipUpgradeSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_center;
        public GLabel m_title;
        public GImage m_n13;
        public GImage m_n18;
        public GImage m_n8;
        public GImage m_n15;
        public GLoader m_img_icon;
        public GLoader m_img_cost;
        public GTextField m_txt_tip;
        public GTextField m_txt_unlock;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_costCount;
        public GList m_list_item;
        public GButton m_btn_back;
        public GButton m_btn_upgrade;
        public const string URL = "ui://em095moesig28";

        public static UI_PetExclusiveEquipUpgradeSkin CreateInstance()
        {
            return (UI_PetExclusiveEquipUpgradeSkin)UIPackage.CreateComponet("Pet", "PetExclusiveEquipUpgradeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_center = (GLoader)GetChildAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_n13 = (GImage)GetChildAt(3);
            m_n18 = (GImage)GetChildAt(4);
            m_n8 = (GImage)GetChildAt(5);
            m_n15 = (GImage)GetChildAt(6);
            m_img_icon = (GLoader)GetChildAt(7);
            m_img_cost = (GLoader)GetChildAt(8);
            m_txt_tip = (GTextField)GetChildAt(9);
            m_txt_unlock = (GTextField)GetChildAt(10);
            m_txt_desc = (GRichTextField)GetChildAt(11);
            m_txt_costCount = (GRichTextField)GetChildAt(12);
            m_list_item = (GList)GetChildComAt(13);
            m_btn_back = (GButton)GetChildComAt(14);
            m_btn_upgrade = (GButton)GetChildComAt(15);
        }
    }
}