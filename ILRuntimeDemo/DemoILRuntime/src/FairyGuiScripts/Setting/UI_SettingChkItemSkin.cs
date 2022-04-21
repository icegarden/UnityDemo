/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingChkItemSkin : GButton
    {
        public Controller m_button;
        public GButton m_btn_select;
        public GTextField m_title;
        public const string URL = "ui://wi3k1s54j3xs13";

        public static UI_SettingChkItemSkin CreateInstance()
        {
            return (UI_SettingChkItemSkin)UIPackage.CreateComponet("Setting", "SettingChkItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_btn_select = (GButton)GetChildComAt(0);
            m_title = (GTextField)GetChildAt(1);
        }
    }
}