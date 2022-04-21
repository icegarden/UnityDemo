/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneTipsViewSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n15;
        public GComponent m_item;
        public GTextField m_txt_level;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_tip;
        public GRichTextField m_txt_name;
        public GList m_list_baseAttr;
        public GButton m_btn_compose;
        public GButton m_btn_remove;
        public GButton m_btn_replace;
        public GGraph m_n31;
        public GGroup m_n30;
        public const string URL = "ui://em095moert0b11";

        public static UI_PetStoneTipsViewSkin CreateInstance()
        {
            return (UI_PetStoneTipsViewSkin)UIPackage.CreateComponet("Pet", "PetStoneTipsViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n15 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_txt_level = (GTextField)GetChildAt(3);
            m_txt_power = (GTextField)GetChildAt(4);
            m_txt_type = (GTextField)GetChildAt(5);
            m_txt_tip = (GTextField)GetChildAt(6);
            m_txt_name = (GRichTextField)GetChildAt(7);
            m_list_baseAttr = (GList)GetChildComAt(8);
            m_btn_compose = (GButton)GetChildComAt(9);
            m_btn_remove = (GButton)GetChildComAt(10);
            m_btn_replace = (GButton)GetChildComAt(11);
            m_n31 = (GGraph)GetChildAt(12);
            m_n30 = (GGroup)GetChildAt(13);
        }
    }
}