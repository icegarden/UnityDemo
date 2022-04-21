/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_PetHallSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GComponent m_n27;
        public GImage m_n28;
        public GImage m_n26;
        public GComponent m_con_avatar;
        public GRichTextField m_txt_count;
        public GList m_list_pet;
        public GGraph m_n29;
        public GButton m_btn_tab0;
        public GButton m_btn_tab1;
        public GButton m_btn_tab2;
        public GButton m_btn_tab3;
        public GButton m_btn_tab4;
        public GButton m_btn_tab5;
        public GButton m_btn_tab6;
        public GGroup m_n30;
        public const string URL = "ui://wua6gzxlikzm20";

        public static UI_PetHallSkin CreateInstance()
        {
            return (UI_PetHallSkin)UIPackage.CreateComponet("Home", "PetHallSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_n27 = (GComponent)GetChildComAt(1);
            m_n28 = (GImage)GetChildAt(2);
            m_n26 = (GImage)GetChildAt(3);
            m_con_avatar = (GComponent)GetChildComAt(4);
            m_txt_count = (GRichTextField)GetChildAt(5);
            m_list_pet = (GList)GetChildComAt(6);
            m_n29 = (GGraph)GetChildAt(7);
            m_btn_tab0 = (GButton)GetChildComAt(8);
            m_btn_tab1 = (GButton)GetChildComAt(9);
            m_btn_tab2 = (GButton)GetChildComAt(10);
            m_btn_tab3 = (GButton)GetChildComAt(11);
            m_btn_tab4 = (GButton)GetChildComAt(12);
            m_btn_tab5 = (GButton)GetChildComAt(13);
            m_btn_tab6 = (GButton)GetChildComAt(14);
            m_n30 = (GGroup)GetChildAt(15);
        }
    }
}