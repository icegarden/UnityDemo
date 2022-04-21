/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingViewSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n2;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_music;
        public GTextField m_txt_sound;
        public GTextField m_txt_voice;
        public GTextField m_txt_imgQuality;
        public GTextField m_txt_ignore;
        public GTextField m_txt_battery;
        public GTextField m_txt_clickEffect;
        public GButton m_btn_subMusic;
        public GButton m_btn_addMusic;
        public GSlider m_btn_slideMusic;
        public GButton m_btn_subSound;
        public GButton m_btn_addSound;
        public GSlider m_btn_slideSound;
        public GButton m_btn_subVoice;
        public GButton m_btn_addVoice;
        public GSlider m_btn_slideVoice;
        public UI_SwtichButton m_btn_ignore;
        public UI_SwtichButton m_btn_imgQuality;
        public UI_SwtichButton m_btn_battery;
        public UI_SwtichButton m_btn_clickEffect;
        public UI_SettingButton m_btn_cdkey;
        public UI_SettingButton m_btn_clause;
        public UI_SettingButton m_btn_language;
        public UI_SettingButton m_btn_notice;
        public UI_SettingButton m_btn_account;
        public UI_SettingButton m_btn_server;
        public UI_SettingButton m_btn_bulletin;
        public UI_SettingButton m_btn_service;
        public const string URL = "ui://wi3k1s54fjwr2";

        public static UI_SettingViewSkin CreateInstance()
        {
            return (UI_SettingViewSkin)UIPackage.CreateComponet("Setting", "SettingViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_tip1 = (GTextField)GetChildAt(2);
            m_txt_tip2 = (GTextField)GetChildAt(3);
            m_txt_music = (GTextField)GetChildAt(4);
            m_txt_sound = (GTextField)GetChildAt(5);
            m_txt_voice = (GTextField)GetChildAt(6);
            m_txt_imgQuality = (GTextField)GetChildAt(7);
            m_txt_ignore = (GTextField)GetChildAt(8);
            m_txt_battery = (GTextField)GetChildAt(9);
            m_txt_clickEffect = (GTextField)GetChildAt(10);
            m_btn_subMusic = (GButton)GetChildComAt(11);
            m_btn_addMusic = (GButton)GetChildComAt(12);
            m_btn_slideMusic = (GSlider)GetChildComAt(13);
            m_btn_subSound = (GButton)GetChildComAt(14);
            m_btn_addSound = (GButton)GetChildComAt(15);
            m_btn_slideSound = (GSlider)GetChildComAt(16);
            m_btn_subVoice = (GButton)GetChildComAt(17);
            m_btn_addVoice = (GButton)GetChildComAt(18);
            m_btn_slideVoice = (GSlider)GetChildComAt(19);
            m_btn_ignore = (UI_SwtichButton)GetChildComAt(20);
            m_btn_imgQuality = (UI_SwtichButton)GetChildComAt(21);
            m_btn_battery = (UI_SwtichButton)GetChildComAt(22);
            m_btn_clickEffect = (UI_SwtichButton)GetChildComAt(23);
            m_btn_cdkey = (UI_SettingButton)GetChildComAt(24);
            m_btn_clause = (UI_SettingButton)GetChildComAt(25);
            m_btn_language = (UI_SettingButton)GetChildComAt(26);
            m_btn_notice = (UI_SettingButton)GetChildComAt(27);
            m_btn_account = (UI_SettingButton)GetChildComAt(28);
            m_btn_server = (UI_SettingButton)GetChildComAt(29);
            m_btn_bulletin = (UI_SettingButton)GetChildComAt(30);
            m_btn_service = (UI_SettingButton)GetChildComAt(31);
        }
    }
}