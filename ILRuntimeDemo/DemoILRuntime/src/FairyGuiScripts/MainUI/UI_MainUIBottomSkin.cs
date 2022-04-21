/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainUI
{
    public partial class UI_MainUIBottomSkin : GComponent
    {
        public Controller m_tab;
        public GImage m_n8;
        public GLoader m_img_bg;
        public UI_BottomTab m_btn_main;
        public UI_BottomTab m_btn_role;
        public UI_BottomTab m_btn_battle;
        public UI_BottomTab m_btn_pet;
        public UI_BottomTab m_btn_world;
        public const string URL = "ui://eb1q6ro1d5pd0";

        public static UI_MainUIBottomSkin CreateInstance()
        {
            return (UI_MainUIBottomSkin)UIPackage.CreateComponet("MainUI", "MainUIBottomSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_n8 = (GImage)GetChildAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_btn_main = (UI_BottomTab)GetChildComAt(2);
            m_btn_role = (UI_BottomTab)GetChildComAt(3);
            m_btn_battle = (UI_BottomTab)GetChildComAt(4);
            m_btn_pet = (UI_BottomTab)GetChildComAt(5);
            m_btn_world = (UI_BottomTab)GetChildComAt(6);
        }
    }
}