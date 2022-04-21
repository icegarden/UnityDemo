/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_img_bottom;
        public GLabel m_title;
        public GButton m_btn_back;
        public GList m_list_reward;
        public const string URL = "ui://l0x7u1wbo1uc0";

        public static UI_GuildRewardSkin CreateInstance()
        {
            return (UI_GuildRewardSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_btn_back = (GButton)GetChildComAt(3);
            m_list_reward = (GList)GetChildComAt(4);
        }
    }
}