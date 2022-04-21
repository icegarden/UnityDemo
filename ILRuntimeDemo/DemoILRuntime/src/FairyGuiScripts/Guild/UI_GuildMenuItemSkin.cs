/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildMenuItemSkin : GComponent
    {
        public GImage m_n1;
        public GTextField m_title;
        public GLoader m_icon;
        public const string URL = "ui://tae9x4e9yfna18";

        public static UI_GuildMenuItemSkin CreateInstance()
        {
            return (UI_GuildMenuItemSkin)UIPackage.CreateComponet("Guild", "GuildMenuItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
            m_icon = (GLoader)GetChildAt(2);
        }
    }
}