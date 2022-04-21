/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldTalentTipsSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GLoader m_img_top;
        public GImage m_n19;
        public GImage m_n20;
        public GImage m_n21;
        public GTextField m_txt_level;
        public GTextField m_txt_max;
        public GTextField m_txt_cost;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_effect;
        public GRichTextField m_txt_nextEffect;
        public UI_WorldTalentItemSkin m_item_talent;
        public GList m_list_cost;
        public GButton m_btn_upgrade;
        public const string URL = "ui://63ubk2jodibia";

        public static UI_WorldTalentTipsSkin CreateInstance()
        {
            return (UI_WorldTalentTipsSkin)UIPackage.CreateComponet("World", "WorldTalentTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_n19 = (GImage)GetChildAt(2);
            m_n20 = (GImage)GetChildAt(3);
            m_n21 = (GImage)GetChildAt(4);
            m_txt_level = (GTextField)GetChildAt(5);
            m_txt_max = (GTextField)GetChildAt(6);
            m_txt_cost = (GTextField)GetChildAt(7);
            m_txt_desc = (GRichTextField)GetChildAt(8);
            m_txt_effect = (GRichTextField)GetChildAt(9);
            m_txt_nextEffect = (GRichTextField)GetChildAt(10);
            m_item_talent = (UI_WorldTalentItemSkin)GetChildComAt(11);
            m_list_cost = (GList)GetChildComAt(12);
            m_btn_upgrade = (GButton)GetChildComAt(13);
        }
    }
}