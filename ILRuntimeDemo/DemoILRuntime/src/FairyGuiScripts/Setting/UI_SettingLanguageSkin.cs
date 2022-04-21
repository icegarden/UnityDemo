/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingLanguageSkin : GComponent
    {
        public GLabel m_bg;
        public UI_SettingChkItemSkin m_btn_CN;
        public UI_SettingChkItemSkin m_btn_EN;
        public GButton m_btn_close;
        public const string URL = "ui://wi3k1s54j3xs14";

        public static UI_SettingLanguageSkin CreateInstance()
        {
            return (UI_SettingLanguageSkin)UIPackage.CreateComponet("Setting", "SettingLanguageSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_btn_CN = (UI_SettingChkItemSkin)GetChildComAt(1);
            m_btn_EN = (UI_SettingChkItemSkin)GetChildComAt(2);
            m_btn_close = (GButton)GetChildComAt(3);
        }
    }
}