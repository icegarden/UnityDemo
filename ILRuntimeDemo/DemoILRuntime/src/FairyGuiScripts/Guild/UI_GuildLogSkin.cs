/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildLogSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_log;
        public GGroup m_n6;
        public const string URL = "ui://tae9x4e9yfna14";

        public static UI_GuildLogSkin CreateInstance()
        {
            return (UI_GuildLogSkin)UIPackage.CreateComponet("Guild", "GuildLogSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_log = (GList)GetChildComAt(1);
            m_n6 = (GGroup)GetChildAt(2);
        }
    }
}