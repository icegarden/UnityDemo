/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneTipsSkin : GComponent
    {
        public GImage m_bg;
        public GImage m_n32;
        public GGraph m_n50;
        public GComponent m_item;
        public GTextField m_txt_level;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_tip;
        public GTextField m_txt_equip;
        public GRichTextField m_txt_name;
        public GList m_list_baseAttr;
        public GButton m_btn_equip;
        public const string URL = "ui://em095moert0bz";

        public static UI_PetStoneTipsSkin CreateInstance()
        {
            return (UI_PetStoneTipsSkin)UIPackage.CreateComponet("Pet", "PetStoneTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_n32 = (GImage)GetChildAt(1);
            m_n50 = (GGraph)GetChildAt(2);
            m_item = (GComponent)GetChildComAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_txt_power = (GTextField)GetChildAt(5);
            m_txt_type = (GTextField)GetChildAt(6);
            m_txt_tip = (GTextField)GetChildAt(7);
            m_txt_equip = (GTextField)GetChildAt(8);
            m_txt_name = (GRichTextField)GetChildAt(9);
            m_list_baseAttr = (GList)GetChildComAt(10);
            m_btn_equip = (GButton)GetChildComAt(11);
        }
    }
}