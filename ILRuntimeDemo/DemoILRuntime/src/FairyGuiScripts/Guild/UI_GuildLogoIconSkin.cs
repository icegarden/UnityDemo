/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildLogoIconSkin : GLabel
    {
        public GImage m_n12;
        public GLoader m_img_icon;
        public const string URL = "ui://tae9x4e9yfnaj";

        public static UI_GuildLogoIconSkin CreateInstance()
        {
            return (UI_GuildLogoIconSkin)UIPackage.CreateComponet("Guild", "GuildLogoIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n12 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
        }
    }
}