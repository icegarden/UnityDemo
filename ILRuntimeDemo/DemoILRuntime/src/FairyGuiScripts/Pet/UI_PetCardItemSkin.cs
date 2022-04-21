/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetCardItemSkin : GComponent
    {
        public Controller m_state;
        public Controller m_tag;
        public GImage m_n29;
        public GLoader m_img_icon;
        public GLoader m_img_bg;
        public GLoader m_img_quality;
        public GLoader m_img_type;
        public GTextField m_txt_eLevel;
        public GImage m_img_mask;
        public GImage m_img_explore;
        public GImage m_img_fight;
        public GTextField m_txt_fight;
        public GTextField m_txt_assign;
        public GButton m_btn_select;
        public GTextField m_txt_level;
        public const string URL = "ui://em095moert0b1";

        public static UI_PetCardItemSkin CreateInstance()
        {
            return (UI_PetCardItemSkin)UIPackage.CreateComponet("Pet", "PetCardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_tag = GetControllerAt(1);
            m_n29 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_bg = (GLoader)GetChildAt(2);
            m_img_quality = (GLoader)GetChildAt(3);
            m_img_type = (GLoader)GetChildAt(4);
            m_txt_eLevel = (GTextField)GetChildAt(5);
            m_img_mask = (GImage)GetChildAt(6);
            m_img_explore = (GImage)GetChildAt(7);
            m_img_fight = (GImage)GetChildAt(8);
            m_txt_fight = (GTextField)GetChildAt(9);
            m_txt_assign = (GTextField)GetChildAt(10);
            m_btn_select = (GButton)GetChildComAt(11);
            m_txt_level = (GTextField)GetChildAt(12);
        }
    }
}