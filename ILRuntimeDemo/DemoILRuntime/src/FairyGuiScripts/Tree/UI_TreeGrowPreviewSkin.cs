/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeGrowPreviewSkin : GComponent
    {
        public Controller m_c1;
        public GLabel m_bg;
        public GImage m_n10;
        public GImage m_n0;
        public GList m_list_pet;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GTextField m_txt_msg;
        public GLoader m_img_none;
        public GTextField m_txt_none;
        public GGroup m_n13;
        public const string URL = "ui://jj5xd8f5mde41c";

        public static UI_TreeGrowPreviewSkin CreateInstance()
        {
            return (UI_TreeGrowPreviewSkin)UIPackage.CreateComponet("Tree", "TreeGrowPreviewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_c1 = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n10 = (GImage)GetChildAt(1);
            m_n0 = (GImage)GetChildAt(2);
            m_list_pet = (GList)GetChildComAt(3);
            m_btn_tab0 = (GButton)GetChildComAt(4);
            m_btn_tab1 = (GButton)GetChildComAt(5);
            m_btn_tab2 = (GButton)GetChildComAt(6);
            m_btn_tab3 = (GButton)GetChildComAt(7);
            m_btn_tab4 = (GButton)GetChildComAt(8);
            m_btn_tab5 = (GButton)GetChildComAt(9);
            m_btn_tab6 = (GButton)GetChildComAt(10);
            m_txt_msg = (GTextField)GetChildAt(11);
            m_img_none = (GLoader)GetChildAt(12);
            m_txt_none = (GTextField)GetChildAt(13);
            m_n13 = (GGroup)GetChildAt(14);
        }
    }
}