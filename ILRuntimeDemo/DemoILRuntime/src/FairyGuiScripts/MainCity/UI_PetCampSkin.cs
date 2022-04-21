/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCity
{
    public partial class UI_PetCampSkin : GComponent
    {
        public Controller m_tab;
        public GComponent m_view_evo;
        public GComponent m_view_reborn;
        public GLabel m_title;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GButton m_tab_reborn;
        public GButton m_tab_reset;
        public GButton m_tab_evo;
        public const string URL = "ui://ewnupz9mdd2m10";

        public static UI_PetCampSkin CreateInstance()
        {
            return (UI_PetCampSkin)UIPackage.CreateComponet("MainCity", "PetCampSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_view_evo = (GComponent)GetChildComAt(0);
            m_view_reborn = (GComponent)GetChildComAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_img_bottom = (GLoader)GetChildAt(3);
            m_btn_back = (GButton)GetChildComAt(4);
            m_tab_reborn = (GButton)GetChildComAt(5);
            m_tab_reset = (GButton)GetChildComAt(6);
            m_tab_evo = (GButton)GetChildComAt(7);
        }
    }
}