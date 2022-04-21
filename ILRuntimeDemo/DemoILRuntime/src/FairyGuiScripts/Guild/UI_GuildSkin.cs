/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_img_bottom;
        public GLabel m_title;
        public GButton m_btn_reward0;
        public GButton m_btn_reward1;
        public GButton m_btn_reward2;
        public GButton m_btn_back;
        public GButton m_btn_hall;
        public GButton m_btn_risk;
        public GButton m_btn_shop;
        public GButton m_btn_rewardHall;
        public GButton m_btn_technology;
        public const string URL = "ui://tae9x4e9yfna1g";

        public static UI_GuildSkin CreateInstance()
        {
            return (UI_GuildSkin)UIPackage.CreateComponet("Guild", "GuildSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_btn_reward0 = (GButton)GetChildComAt(3);
            m_btn_reward1 = (GButton)GetChildComAt(4);
            m_btn_reward2 = (GButton)GetChildComAt(5);
            m_btn_back = (GButton)GetChildComAt(6);
            m_btn_hall = (GButton)GetChildComAt(7);
            m_btn_risk = (GButton)GetChildComAt(8);
            m_btn_shop = (GButton)GetChildComAt(9);
            m_btn_rewardHall = (GButton)GetChildComAt(10);
            m_btn_technology = (GButton)GetChildComAt(11);
        }
    }
}