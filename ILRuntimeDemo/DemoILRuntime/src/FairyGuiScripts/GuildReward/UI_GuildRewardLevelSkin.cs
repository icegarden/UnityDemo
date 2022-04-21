/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardLevelSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GTextField m_txt_title0;
        public GLoader m_img_tilte1;
        public GLoader m_img_tilte2;
        public GLoader m_img_tilte3;
        public GList m_list_level;
        public const string URL = "ui://l0x7u1wbx7iaz";

        public static UI_GuildRewardLevelSkin CreateInstance()
        {
            return (UI_GuildRewardLevelSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardLevelSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_txt_title0 = (GTextField)GetChildAt(2);
            m_img_tilte1 = (GLoader)GetChildAt(3);
            m_img_tilte2 = (GLoader)GetChildAt(4);
            m_img_tilte3 = (GLoader)GetChildAt(5);
            m_list_level = (GList)GetChildComAt(6);
        }
    }
}