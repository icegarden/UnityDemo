/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildActiveValueSkin : GLabel
    {
        public GImage m_n18;
        public GImage m_n19;
        public GTextField m_title;
        public const string URL = "ui://tae9x4e9yfnai";

        public static UI_GuildActiveValueSkin CreateInstance()
        {
            return (UI_GuildActiveValueSkin)UIPackage.CreateComponet("Guild", "GuildActiveValueSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n18 = (GImage)GetChildAt(0);
            m_n19 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}