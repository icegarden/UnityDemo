/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCity
{
    public partial class UI_MainCitySkin : GComponent
    {
        public UI_MainCityView m_mainview;
        public GImage m_bg_right;
        public UI_RightMenuSkin m_menu_right;
        public GButton m_btn_bag;
        public GButton m_btn_dropRight;
        public GGroup m_gp_right;
        public Transition m_hideRight;
        public const string URL = "ui://ewnupz9md5pd0";

        public static UI_MainCitySkin CreateInstance()
        {
            return (UI_MainCitySkin)UIPackage.CreateComponet("MainCity", "MainCitySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_mainview = (UI_MainCityView)GetChildComAt(0);
            m_bg_right = (GImage)GetChildAt(1);
            m_menu_right = (UI_RightMenuSkin)GetChildComAt(2);
            m_btn_bag = (GButton)GetChildComAt(3);
            m_btn_dropRight = (GButton)GetChildComAt(4);
            m_gp_right = (GGroup)GetChildAt(5);
            m_hideRight = GetTransitionAt(0);
        }
    }
}