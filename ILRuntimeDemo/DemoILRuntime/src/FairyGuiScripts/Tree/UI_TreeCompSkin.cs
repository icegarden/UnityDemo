/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeCompSkin : GComponent
    {
        public UI_empty m_avt_con;
        public GImage m_n24;
        public GImage m_n25;
        public GImage m_n26;
        public GImage m_n27;
        public GImage m_n28;
        public GImage m_n13;
        public GButton m_btn_add;
        public GImage m_n10;
        public GTextField m_txt_num;
        public GTextField m_txt_msg0;
        public GTextField m_txt_lv0;
        public GTextField m_txt_lv1;
        public GTextField m_txt_lv2;
        public GTextField m_txt_lv3;
        public GTextField m_txt_lv4;
        public GList m_list_pet;
        public GButton m_btn_upgrade;
        public const string URL = "ui://jj5xd8f5mde4m";

        public static UI_TreeCompSkin CreateInstance()
        {
            return (UI_TreeCompSkin)UIPackage.CreateComponet("Tree", "TreeCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_avt_con = (UI_empty)GetChildComAt(0);
            m_n24 = (GImage)GetChildAt(1);
            m_n25 = (GImage)GetChildAt(2);
            m_n26 = (GImage)GetChildAt(3);
            m_n27 = (GImage)GetChildAt(4);
            m_n28 = (GImage)GetChildAt(5);
            m_n13 = (GImage)GetChildAt(6);
            m_btn_add = (GButton)GetChildComAt(7);
            m_n10 = (GImage)GetChildAt(8);
            m_txt_num = (GTextField)GetChildAt(9);
            m_txt_msg0 = (GTextField)GetChildAt(10);
            m_txt_lv0 = (GTextField)GetChildAt(11);
            m_txt_lv1 = (GTextField)GetChildAt(12);
            m_txt_lv2 = (GTextField)GetChildAt(13);
            m_txt_lv3 = (GTextField)GetChildAt(14);
            m_txt_lv4 = (GTextField)GetChildAt(15);
            m_list_pet = (GList)GetChildComAt(16);
            m_btn_upgrade = (GButton)GetChildComAt(17);
        }
    }
}