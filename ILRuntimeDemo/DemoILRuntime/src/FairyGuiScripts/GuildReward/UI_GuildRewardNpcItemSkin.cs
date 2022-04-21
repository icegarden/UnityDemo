/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardNpcItemSkin : GButton
    {
        public Controller m_button;
        public GImage m_n6;
        public GImage m_n12;
        public UI_GuildRewardNpcItem2Skin m_comp_detail;
        public GImage m_n13;
        public const string URL = "ui://l0x7u1wbo1ucl";

        public static UI_GuildRewardNpcItemSkin CreateInstance()
        {
            return (UI_GuildRewardNpcItemSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardNpcItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n6 = (GImage)GetChildAt(0);
            m_n12 = (GImage)GetChildAt(1);
            m_comp_detail = (UI_GuildRewardNpcItem2Skin)GetChildComAt(2);
            m_n13 = (GImage)GetChildAt(3);
        }
    }
}