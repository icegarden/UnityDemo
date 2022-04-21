/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildCostSkin : GComponent
    {
        public GLoader m_img_icon;
        public GRichTextField m_txt_count;
        public const string URL = "ui://l0x7u1wbmde412";

        public static UI_GuildCostSkin CreateInstance()
        {
            return (UI_GuildCostSkin)UIPackage.CreateComponet("GuildReward", "GuildCostSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_count = (GRichTextField)GetChildAt(1);
        }
    }
}