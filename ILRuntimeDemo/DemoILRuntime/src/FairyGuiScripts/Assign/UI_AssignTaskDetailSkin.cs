/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignTaskDetailSkin : GComponent
    {
        public Controller m_tab;
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GImage m_n27;
        public GImage m_n28;
        public GImage m_n31;
        public GImage m_n45;
        public GImage m_n41;
        public GImage m_n29;
        public GImage m_n39;
        public GTextField m_txt_rewardTitle;
        public GTextField m_txt_timeTitle;
        public GTextField m_txt_time;
        public GList m_list_reward;
        public GList m_list_condition;
        public GList m_list_explore;
        public GList m_list_pet;
        public GButton m_btn_explore;
        public GButton m_btn_onekey;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public const string URL = "ui://e8jsnjd3gikd7";

        public static UI_AssignTaskDetailSkin CreateInstance()
        {
            return (UI_AssignTaskDetailSkin)UIPackage.CreateComponet("Assign", "AssignTaskDetailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_n27 = (GImage)GetChildAt(2);
            m_n28 = (GImage)GetChildAt(3);
            m_n31 = (GImage)GetChildAt(4);
            m_n45 = (GImage)GetChildAt(5);
            m_n41 = (GImage)GetChildAt(6);
            m_n29 = (GImage)GetChildAt(7);
            m_n39 = (GImage)GetChildAt(8);
            m_txt_rewardTitle = (GTextField)GetChildAt(9);
            m_txt_timeTitle = (GTextField)GetChildAt(10);
            m_txt_time = (GTextField)GetChildAt(11);
            m_list_reward = (GList)GetChildComAt(12);
            m_list_condition = (GList)GetChildComAt(13);
            m_list_explore = (GList)GetChildComAt(14);
            m_list_pet = (GList)GetChildComAt(15);
            m_btn_explore = (GButton)GetChildComAt(16);
            m_btn_onekey = (GButton)GetChildComAt(17);
            m_btn_tab0 = (GButton)GetChildComAt(18);
            m_btn_tab1 = (GButton)GetChildComAt(19);
            m_btn_tab2 = (GButton)GetChildComAt(20);
            m_btn_tab3 = (GButton)GetChildComAt(21);
            m_btn_tab4 = (GButton)GetChildComAt(22);
            m_btn_tab5 = (GButton)GetChildComAt(23);
            m_btn_tab6 = (GButton)GetChildComAt(24);
        }
    }
}