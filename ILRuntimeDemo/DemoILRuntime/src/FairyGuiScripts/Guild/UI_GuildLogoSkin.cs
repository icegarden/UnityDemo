/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildLogoSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_logo;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n3;
        public const string URL = "ui://tae9x4e9yfna1d";

        public static UI_GuildLogoSkin CreateInstance()
        {
            return (UI_GuildLogoSkin)UIPackage.CreateComponet("Guild", "GuildLogoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_logo = (GList)GetChildComAt(1);
            m_btn_confirm = (GButton)GetChildComAt(2);
            m_btn_cancel = (GButton)GetChildComAt(3);
            m_n3 = (GGroup)GetChildAt(4);
        }
    }
}