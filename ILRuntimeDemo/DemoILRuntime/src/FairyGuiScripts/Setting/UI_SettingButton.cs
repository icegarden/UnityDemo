/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingButton : GButton
    {
        public GImage m_n0;
        public GLoader m_icon;
        public GTextField m_title;
        public const string URL = "ui://wi3k1s54j3xsy";

        public static UI_SettingButton CreateInstance()
        {
            return (UI_SettingButton)UIPackage.CreateComponet("Setting", "SettingButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}