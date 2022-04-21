/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetIntimateSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n23;
        public GImage m_n29;
        public GGraph m_n37;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_evolutionLevel;
        public GRichTextField m_txt_intimate;
        public GRichTextField m_txt_cost;
        public GTextInput m_txt_useCount;
        public GTextField m_txt_tip1;
        public GLabel m_txt_desc;
        public GList m_list_item;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_use;
        public GGraph m_bg_tips;
        public GImage m_n17;
        public GTextField m_txt_intimate2;
        public GTextField m_txt_effect;
        public GRichTextField m_txt_help;
        public GGroup m_gp_tips;
        public GGroup m_n34;
        public const string URL = "ui://em095moert0bn";

        public static UI_PetIntimateSkin CreateInstance()
        {
            return (UI_PetIntimateSkin)UIPackage.CreateComponet("Pet", "PetIntimateSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n23 = (GImage)GetChildAt(1);
            m_n29 = (GImage)GetChildAt(2);
            m_n37 = (GGraph)GetChildAt(3);
            m_img_bg = (GLoader)GetChildAt(4);
            m_img_icon = (GLoader)GetChildAt(5);
            m_img_slot = (GLoader)GetChildAt(6);
            m_txt_name = (GRichTextField)GetChildAt(7);
            m_txt_evolutionLevel = (GRichTextField)GetChildAt(8);
            m_txt_intimate = (GRichTextField)GetChildAt(9);
            m_txt_cost = (GRichTextField)GetChildAt(10);
            m_txt_useCount = (GTextInput)GetChildAt(11);
            m_txt_tip1 = (GTextField)GetChildAt(12);
            m_txt_desc = (GLabel)GetChildComAt(13);
            m_list_item = (GList)GetChildComAt(14);
            m_btn_sub = (GButton)GetChildComAt(15);
            m_btn_add = (GButton)GetChildComAt(16);
            m_btn_slide = (GSlider)GetChildComAt(17);
            m_btn_use = (GButton)GetChildComAt(18);
            m_bg_tips = (GGraph)GetChildAt(19);
            m_n17 = (GImage)GetChildAt(20);
            m_txt_intimate2 = (GTextField)GetChildAt(21);
            m_txt_effect = (GTextField)GetChildAt(22);
            m_txt_help = (GRichTextField)GetChildAt(23);
            m_gp_tips = (GGroup)GetChildAt(24);
            m_n34 = (GGroup)GetChildAt(25);
        }
    }
}