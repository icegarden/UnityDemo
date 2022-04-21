/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildMenuSkin : GComponent
    {
        public GImage m_n0;
        public GList m_list_menu;
        public const string URL = "ui://tae9x4e9yfna16";

        public static UI_GuildMenuSkin CreateInstance()
        {
            return (UI_GuildMenuSkin)UIPackage.CreateComponet("Guild", "GuildMenuSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_list_menu = (GList)GetChildComAt(1);
        }
    }
}