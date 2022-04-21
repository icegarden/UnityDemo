/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCity
{
    public partial class UI_MainCityView : GComponent
    {
        public GLoader m_bg;
        public GComponent m_con_bottom;
        public GLoader m_bg_middle;
        public GComponent m_con_up;
        public GLoader m_bg_front;
        public UI_mainButton m_btn_petProduce;
        public UI_mainButton m_btn_home;
        public UI_mainButton m_btn_library;
        public UI_mainButton m_btn_shop;
        public UI_mainButton m_btn_compose;
        public UI_mainButton m_btn_assign;
        public UI_mainButton m_btn_evolution;
        public UI_mainButton m_btn_halidom;
        public UI_mainButton m_btn_ship;
        public UI_mainButton m_btn_starSign;
        public UI_mainButton m_btn_guild;
        public UI_mainButton m_btn_formation;
        public const string URL = "ui://ewnupz9mg55wt";

        public static UI_MainCityView CreateInstance()
        {
            return (UI_MainCityView)UIPackage.CreateComponet("MainCity", "MainCityView");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_con_bottom = (GComponent)GetChildComAt(1);
            m_bg_middle = (GLoader)GetChildAt(2);
            m_con_up = (GComponent)GetChildComAt(3);
            m_bg_front = (GLoader)GetChildAt(4);
            m_btn_petProduce = (UI_mainButton)GetChildComAt(5);
            m_btn_home = (UI_mainButton)GetChildComAt(6);
            m_btn_library = (UI_mainButton)GetChildComAt(7);
            m_btn_shop = (UI_mainButton)GetChildComAt(8);
            m_btn_compose = (UI_mainButton)GetChildComAt(9);
            m_btn_assign = (UI_mainButton)GetChildComAt(10);
            m_btn_evolution = (UI_mainButton)GetChildComAt(11);
            m_btn_halidom = (UI_mainButton)GetChildComAt(12);
            m_btn_ship = (UI_mainButton)GetChildComAt(13);
            m_btn_starSign = (UI_mainButton)GetChildComAt(14);
            m_btn_guild = (UI_mainButton)GetChildComAt(15);
            m_btn_formation = (UI_mainButton)GetChildComAt(16);
        }
    }
}