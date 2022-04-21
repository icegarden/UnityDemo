/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildLogoItemSkin : GButton
    {
        public Controller m_button;
        public Controller m_control;
        public GImage m_n0;
        public GLoader m_icon;
        public GImage m_n1;
        public GImage m_n3;
        public GImage m_n4;
        public GTextField m_txt_unlock;
        public const string URL = "ui://tae9x4e9yfna1e";

        public static UI_GuildLogoItemSkin CreateInstance()
        {
            return (UI_GuildLogoItemSkin)UIPackage.CreateComponet("Guild", "GuildLogoItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_control = GetControllerAt(1);
            m_n0 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_txt_unlock = (GTextField)GetChildAt(5);
        }
    }
}