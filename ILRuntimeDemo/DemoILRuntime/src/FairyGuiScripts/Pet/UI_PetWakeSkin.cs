/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetWakeSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GImage m_n84;
        public GImage m_n85;
        public GImage m_n76;
        public GImage m_n77;
        public GImage m_n78;
        public GImage m_n79;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_full;
        public GLoader m_img_curLevel;
        public GLoader m_img_nextLevel;
        public GComponent m_curHead;
        public GComponent m_nextHead;
        public UI_PetSkillItemSkin m_item_nextSkill;
        public GButton m_btn_confirm;
        public GList m_list_attr;
        public GList m_list_cost;
        public const string URL = "ui://em095moert0bg";

        public static UI_PetWakeSkin CreateInstance()
        {
            return (UI_PetWakeSkin)UIPackage.CreateComponet("Pet", "PetWakeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n84 = (GImage)GetChildAt(1);
            m_n85 = (GImage)GetChildAt(2);
            m_n76 = (GImage)GetChildAt(3);
            m_n77 = (GImage)GetChildAt(4);
            m_n78 = (GImage)GetChildAt(5);
            m_n79 = (GImage)GetChildAt(6);
            m_txt_tip1 = (GTextField)GetChildAt(7);
            m_txt_tip2 = (GTextField)GetChildAt(8);
            m_txt_tip3 = (GTextField)GetChildAt(9);
            m_txt_full = (GTextField)GetChildAt(10);
            m_img_curLevel = (GLoader)GetChildAt(11);
            m_img_nextLevel = (GLoader)GetChildAt(12);
            m_curHead = (GComponent)GetChildComAt(13);
            m_nextHead = (GComponent)GetChildComAt(14);
            m_item_nextSkill = (UI_PetSkillItemSkin)GetChildComAt(15);
            m_btn_confirm = (GButton)GetChildComAt(16);
            m_list_attr = (GList)GetChildComAt(17);
            m_list_cost = (GList)GetChildComAt(18);
        }
    }
}