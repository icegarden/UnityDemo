/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HallSkin : GComponent
    {
        public Controller m_tab;
        public GGraph m_n16;
        public UI_HallViewSkin m_view_hall;
        public UI_PetHallSkin m_view_pet;
        public GLabel m_title;
        public GImage m_n9;
        public GButton m_btn_hall;
        public GButton m_btn_expand;
        public GButton m_btn_back;
        public GButton m_btn_help;
        public GButton m_btn_pet;
        public const string URL = "ui://wua6gzxlikzm1s";

        public static UI_HallSkin CreateInstance()
        {
            return (UI_HallSkin)UIPackage.CreateComponet("Home", "HallSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_n16 = (GGraph)GetChildAt(0);
            m_view_hall = (UI_HallViewSkin)GetChildComAt(1);
            m_view_pet = (UI_PetHallSkin)GetChildComAt(2);
            m_title = (GLabel)GetChildComAt(3);
            m_n9 = (GImage)GetChildAt(4);
            m_btn_hall = (GButton)GetChildComAt(5);
            m_btn_expand = (GButton)GetChildComAt(6);
            m_btn_back = (GButton)GetChildComAt(7);
            m_btn_help = (GButton)GetChildComAt(8);
            m_btn_pet = (GButton)GetChildComAt(9);
        }
    }
}