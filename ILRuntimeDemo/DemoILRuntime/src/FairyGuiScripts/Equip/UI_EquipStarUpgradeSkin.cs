/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipStarUpgradeSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n3;
        public GImage m_n7;
        public GImage m_n9;
        public GImage m_n4;
        public GImage m_n14;
        public GImage m_n13;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_tip4;
        public GList m_list_attr;
        public GList m_list_curStar;
        public GList m_list_nextStar;
        public GProgressBar m_pb_exp;
        public GList m_list_item;
        public GComponent m_item_cost;
        public GButton m_btn_fill;
        public GButton m_btn_upgrade;
        public const string URL = "ui://5ch1xwvwh7469b";

        public static UI_EquipStarUpgradeSkin CreateInstance()
        {
            return (UI_EquipStarUpgradeSkin)UIPackage.CreateComponet("Equip", "EquipStarUpgradeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n9 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_n14 = (GImage)GetChildAt(5);
            m_n13 = (GImage)GetChildAt(6);
            m_item = (GComponent)GetChildComAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
            m_txt_tip1 = (GTextField)GetChildAt(9);
            m_txt_tip2 = (GTextField)GetChildAt(10);
            m_txt_tip3 = (GTextField)GetChildAt(11);
            m_txt_tip4 = (GTextField)GetChildAt(12);
            m_list_attr = (GList)GetChildComAt(13);
            m_list_curStar = (GList)GetChildComAt(14);
            m_list_nextStar = (GList)GetChildComAt(15);
            m_pb_exp = (GProgressBar)GetChildComAt(16);
            m_list_item = (GList)GetChildComAt(17);
            m_item_cost = (GComponent)GetChildComAt(18);
            m_btn_fill = (GButton)GetChildComAt(19);
            m_btn_upgrade = (GButton)GetChildComAt(20);
        }
    }
}