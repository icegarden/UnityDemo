/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeSkin : GComponent
    {
        public Controller m_control;
        public GLoader m_bg;
        public GLoader m_bg_list1;
        public GLoader m_bg_list2;
        public GLoader m_img_bottom;
        public GImage m_n5;
        public GTextField m_txt_name;
        public GButton m_btn_back;
        public UI_TreeCompSkin m_comp_tree;
        public UI_WishCompSkin m_comp_wish;
        public GButton m_n0;
        public GButton m_n1;
        public GGroup m_g_bottom;
        public const string URL = "ui://jj5xd8f5mde40";

        public static UI_TreeSkin CreateInstance()
        {
            return (UI_TreeSkin)UIPackage.CreateComponet("Tree", "TreeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_bg_list1 = (GLoader)GetChildAt(1);
            m_bg_list2 = (GLoader)GetChildAt(2);
            m_img_bottom = (GLoader)GetChildAt(3);
            m_n5 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_btn_back = (GButton)GetChildComAt(6);
            m_comp_tree = (UI_TreeCompSkin)GetChildComAt(7);
            m_comp_wish = (UI_WishCompSkin)GetChildComAt(8);
            m_n0 = (GButton)GetChildComAt(9);
            m_n1 = (GButton)GetChildComAt(10);
            m_g_bottom = (GGroup)GetChildAt(11);
        }
    }
}