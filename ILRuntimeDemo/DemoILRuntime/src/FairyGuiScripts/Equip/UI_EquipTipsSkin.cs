/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n70;
        public GImage m_n61;
        public GImage m_n71;
        public GImage m_n72;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GTextField m_txt_powerTitle;
        public GTextField m_txt_typeTitle;
        public GTextField m_txt_elementTitle;
        public GTextField m_txt_power;
        public GTextField m_txt_type;
        public GTextField m_txt_element;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_elementDesc;
        public GList m_list_attr;
        public GLoader m_img_type;
        public GLoader m_img_element;
        public GButton m_btn_remove;
        public GButton m_btn_replace;
        public GButton m_btn_upgrade;
        public const string URL = "ui://5ch1xwvwqncm28";

        public static UI_EquipTipsSkin CreateInstance()
        {
            return (UI_EquipTipsSkin)UIPackage.CreateComponet("Equip", "EquipTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n70 = (GImage)GetChildAt(1);
            m_n61 = (GImage)GetChildAt(2);
            m_n71 = (GImage)GetChildAt(3);
            m_n72 = (GImage)GetChildAt(4);
            m_item = (GComponent)GetChildComAt(5);
            m_txt_name = (GRichTextField)GetChildAt(6);
            m_txt_powerTitle = (GTextField)GetChildAt(7);
            m_txt_typeTitle = (GTextField)GetChildAt(8);
            m_txt_elementTitle = (GTextField)GetChildAt(9);
            m_txt_power = (GTextField)GetChildAt(10);
            m_txt_type = (GTextField)GetChildAt(11);
            m_txt_element = (GTextField)GetChildAt(12);
            m_txt_tip1 = (GTextField)GetChildAt(13);
            m_txt_tip2 = (GTextField)GetChildAt(14);
            m_txt_elementDesc = (GRichTextField)GetChildAt(15);
            m_list_attr = (GList)GetChildComAt(16);
            m_img_type = (GLoader)GetChildAt(17);
            m_img_element = (GLoader)GetChildAt(18);
            m_btn_remove = (GButton)GetChildComAt(19);
            m_btn_replace = (GButton)GetChildComAt(20);
            m_btn_upgrade = (GButton)GetChildComAt(21);
        }
    }
}