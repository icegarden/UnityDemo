/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_EquipRefineSkin : GComponent
    {
        public GLabel m_n0;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_power;
        public GTextField m_n5;
        public GImage m_n7;
        public GImage m_n8;
        public GTextField m_n9;
        public GTextField m_n10;
        public GTextField m_n11;
        public GList m_list_curAttr;
        public GList m_list_nextAttr;
        public GList m_list_cost;
        public GButton m_btn_refine;
        public GButton m_btn_save;
        public const string URL = "ui://edfpwlj6oii81l";

        public static UI_EquipRefineSkin CreateInstance()
        {
            return (UI_EquipRefineSkin)UIPackage.CreateComponet("Role", "EquipRefineSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_power = (GRichTextField)GetChildAt(3);
            m_n5 = (GTextField)GetChildAt(4);
            m_n7 = (GImage)GetChildAt(5);
            m_n8 = (GImage)GetChildAt(6);
            m_n9 = (GTextField)GetChildAt(7);
            m_n10 = (GTextField)GetChildAt(8);
            m_n11 = (GTextField)GetChildAt(9);
            m_list_curAttr = (GList)GetChildComAt(10);
            m_list_nextAttr = (GList)GetChildComAt(11);
            m_list_cost = (GList)GetChildComAt(12);
            m_btn_refine = (GButton)GetChildComAt(13);
            m_btn_save = (GButton)GetChildComAt(14);
        }
    }
}