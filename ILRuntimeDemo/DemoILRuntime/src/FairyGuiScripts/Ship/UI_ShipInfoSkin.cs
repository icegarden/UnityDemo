/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipInfoSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GLoader m_img_top;
        public GLoader m_img_middle;
        public GLoader m_img_icon;
        public GImage m_n15;
        public GImage m_n18;
        public GImage m_n20;
        public GImage m_n22;
        public GButton m_img_skillIcon;
        public GImage m_n21;
        public GTextField m_txt_name;
        public GTextField m_txt_tip1;
        public GTextField m_txt_equiped;
        public GTextField m_txt_skillName;
        public GRichTextField m_txt_skillEffect;
        public GList m_list_star;
        public GList m_list_attr;
        public GButton m_btn_create;
        public GButton m_btn_remould;
        public GButton m_btn_equip;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public const string URL = "ui://6uax1a6mdibi2";

        public static UI_ShipInfoSkin CreateInstance()
        {
            return (UI_ShipInfoSkin)UIPackage.CreateComponet("Ship", "ShipInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_img_middle = (GLoader)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_n15 = (GImage)GetChildAt(4);
            m_n18 = (GImage)GetChildAt(5);
            m_n20 = (GImage)GetChildAt(6);
            m_n22 = (GImage)GetChildAt(7);
            m_img_skillIcon = (GButton)GetChildComAt(8);
            m_n21 = (GImage)GetChildAt(9);
            m_txt_name = (GTextField)GetChildAt(10);
            m_txt_tip1 = (GTextField)GetChildAt(11);
            m_txt_equiped = (GTextField)GetChildAt(12);
            m_txt_skillName = (GTextField)GetChildAt(13);
            m_txt_skillEffect = (GRichTextField)GetChildAt(14);
            m_list_star = (GList)GetChildComAt(15);
            m_list_attr = (GList)GetChildComAt(16);
            m_btn_create = (GButton)GetChildComAt(17);
            m_btn_remould = (GButton)GetChildComAt(18);
            m_btn_equip = (GButton)GetChildComAt(19);
            m_btn_left = (GButton)GetChildComAt(20);
            m_btn_right = (GButton)GetChildComAt(21);
        }
    }
}