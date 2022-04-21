/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardNpcItem3Skin : GComponent
    {
        public GImage m_n19;
        public GImage m_n22;
        public GComponent m_item;
        public GTextField m_txt_title;
        public GTextField m_txt_pro;
        public const string URL = "ui://l0x7u1wbo1uco";

        public static UI_GuildRewardNpcItem3Skin CreateInstance()
        {
            return (UI_GuildRewardNpcItem3Skin)UIPackage.CreateComponet("GuildReward", "GuildRewardNpcItem3Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n19 = (GImage)GetChildAt(0);
            m_n22 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_txt_title = (GTextField)GetChildAt(3);
            m_txt_pro = (GTextField)GetChildAt(4);
        }
    }
}