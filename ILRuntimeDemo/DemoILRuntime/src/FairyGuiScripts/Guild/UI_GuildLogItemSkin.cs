/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildLogItemSkin : GComponent
    {
        public GImage m_n2;
        public GTextField m_txt_time;
        public GRichTextField m_txt_log;
        public const string URL = "ui://tae9x4e9yfna15";

        public static UI_GuildLogItemSkin CreateInstance()
        {
            return (UI_GuildLogItemSkin)UIPackage.CreateComponet("Guild", "GuildLogItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_txt_time = (GTextField)GetChildAt(1);
            m_txt_log = (GRichTextField)GetChildAt(2);
        }
    }
}