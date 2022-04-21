/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingNoticeSkin : GComponent
    {
        public GLabel m_bg;
        public GButton m_btn_close;
        public GList m_list_item;
        public const string URL = "ui://wi3k1s54j3xs11";

        public static UI_SettingNoticeSkin CreateInstance()
        {
            return (UI_SettingNoticeSkin)UIPackage.CreateComponet("Setting", "SettingNoticeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_btn_close = (GButton)GetChildComAt(1);
            m_list_item = (GList)GetChildComAt(2);
        }
    }
}