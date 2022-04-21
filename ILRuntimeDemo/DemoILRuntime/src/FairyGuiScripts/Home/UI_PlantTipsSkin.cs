/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_PlantTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_n3;
        public GComponent m_n15;
        public GComponent m_item;
        public GLabel m_txt_desc;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_type;
        public GTextField m_n9;
        public GTextField m_n10;
        public GTextField m_txt_count;
        public GTextField m_n13;
        public GTextField m_txt_time;
        public GTextField m_n18;
        public GList m_list_item;
        public GButton m_btn_remove;
        public GButton m_btn_speedup;
        public GGroup m_n22;
        public const string URL = "ui://wua6gzxlikzm1k";

        public static UI_PlantTipsSkin CreateInstance()
        {
            return (UI_PlantTipsSkin)UIPackage.CreateComponet("Home", "PlantTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n3 = (GComponent)GetChildComAt(1);
            m_n15 = (GComponent)GetChildComAt(2);
            m_item = (GComponent)GetChildComAt(3);
            m_txt_desc = (GLabel)GetChildComAt(4);
            m_txt_name = (GRichTextField)GetChildAt(5);
            m_txt_type = (GRichTextField)GetChildAt(6);
            m_n9 = (GTextField)GetChildAt(7);
            m_n10 = (GTextField)GetChildAt(8);
            m_txt_count = (GTextField)GetChildAt(9);
            m_n13 = (GTextField)GetChildAt(10);
            m_txt_time = (GTextField)GetChildAt(11);
            m_n18 = (GTextField)GetChildAt(12);
            m_list_item = (GList)GetChildComAt(13);
            m_btn_remove = (GButton)GetChildComAt(14);
            m_btn_speedup = (GButton)GetChildComAt(15);
            m_n22 = (GGroup)GetChildAt(16);
        }
    }
}