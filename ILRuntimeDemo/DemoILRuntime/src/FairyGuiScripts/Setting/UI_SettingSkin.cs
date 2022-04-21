/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GLoader m_img_bg1;
        public GButton m_btn_setting;
        public GButton m_btn_info;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n6;
        public GTextField m_txt_title;
        public GTextField m_txt_version;
        public UI_PlayerInfoViewSkin m_view_info;
        public UI_SettingViewSkin m_view_setting;
        public GButton m_btn_back;
        public const string URL = "ui://wi3k1s54fjwr0";

        public static UI_SettingSkin CreateInstance()
        {
            return (UI_SettingSkin)UIPackage.CreateComponet("Setting", "SettingSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_btn_setting = (GButton)GetChildComAt(2);
            m_btn_info = (GButton)GetChildComAt(3);
            m_img_bg2 = (GLoader)GetChildAt(4);
            m_img_top = (GLoader)GetChildAt(5);
            m_n6 = (GImage)GetChildAt(6);
            m_txt_title = (GTextField)GetChildAt(7);
            m_txt_version = (GTextField)GetChildAt(8);
            m_view_info = (UI_PlayerInfoViewSkin)GetChildComAt(9);
            m_view_setting = (UI_SettingViewSkin)GetChildComAt(10);
            m_btn_back = (GButton)GetChildComAt(11);
        }
    }
}