/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_PetStarSignSkin : GComponent
    {
        public Controller m_lock;
        public Controller m_slot;
        public GLoader m_img_bg;
        public GLabel m_title;
        public GLoader m_img_center;
        public GLoader m_img_bottom;
        public GImage m_n8;
        public GImage m_n9;
        public GImage m_n6;
        public GImage m_n23;
        public UI_StarSignSlotSkin m_slot_1;
        public UI_StarSignSlotSkin m_slot_2;
        public UI_StarSignSlotSkin m_slot_3;
        public UI_StarSignSlotSkin m_slot_4;
        public UI_StarSignSlotSkin m_slot_5;
        public UI_StarSignSlotSkin m_slot_6;
        public UI_StarSignSlotSkin m_slot_7;
        public GTextField m_txt_totalLevel;
        public GTextField m_txt_name;
        public GRichTextField m_txt_unlock;
        public GRichTextField m_txt_needLevel;
        public GList m_list_attr;
        public GList m_list_cost;
        public GButton m_btn_reward;
        public GButton m_btn_unlock;
        public GButton m_btn_upgrade;
        public GButton m_btn_back;
        public const string URL = "ui://xplmw3njho4vy";

        public static UI_PetStarSignSkin CreateInstance()
        {
            return (UI_PetStarSignSkin)UIPackage.CreateComponet("StarSign", "PetStarSignSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_lock = GetControllerAt(0);
            m_slot = GetControllerAt(1);
            m_img_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_img_center = (GLoader)GetChildAt(2);
            m_img_bottom = (GLoader)GetChildAt(3);
            m_n8 = (GImage)GetChildAt(4);
            m_n9 = (GImage)GetChildAt(5);
            m_n6 = (GImage)GetChildAt(6);
            m_n23 = (GImage)GetChildAt(7);
            m_slot_1 = (UI_StarSignSlotSkin)GetChildComAt(8);
            m_slot_2 = (UI_StarSignSlotSkin)GetChildComAt(9);
            m_slot_3 = (UI_StarSignSlotSkin)GetChildComAt(10);
            m_slot_4 = (UI_StarSignSlotSkin)GetChildComAt(11);
            m_slot_5 = (UI_StarSignSlotSkin)GetChildComAt(12);
            m_slot_6 = (UI_StarSignSlotSkin)GetChildComAt(13);
            m_slot_7 = (UI_StarSignSlotSkin)GetChildComAt(14);
            m_txt_totalLevel = (GTextField)GetChildAt(15);
            m_txt_name = (GTextField)GetChildAt(16);
            m_txt_unlock = (GRichTextField)GetChildAt(17);
            m_txt_needLevel = (GRichTextField)GetChildAt(18);
            m_list_attr = (GList)GetChildComAt(19);
            m_list_cost = (GList)GetChildComAt(20);
            m_btn_reward = (GButton)GetChildComAt(21);
            m_btn_unlock = (GButton)GetChildComAt(22);
            m_btn_upgrade = (GButton)GetChildComAt(23);
            m_btn_back = (GButton)GetChildComAt(24);
        }
    }
}