/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRewardSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GLoader m_img_bg1;
        public GButton m_btn_daily;
        public GButton m_btn_season;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n38;
        public GImage m_n42;
        public GTextField m_txt_title;
        public GTextField m_txt_time;
        public GTextField m_txt_reward;
        public GList m_list_item;
        public UI_ArenaRewardItemSkin m_item_mine;
        public GButton m_btn_back;
        public const string URL = "ui://m8qegzmncnj3i";

        public static UI_ArenaRewardSkin CreateInstance()
        {
            return (UI_ArenaRewardSkin)UIPackage.CreateComponet("Arena", "ArenaRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_btn_daily = (GButton)GetChildComAt(2);
            m_btn_season = (GButton)GetChildComAt(3);
            m_img_bg2 = (GLoader)GetChildAt(4);
            m_img_top = (GLoader)GetChildAt(5);
            m_n38 = (GImage)GetChildAt(6);
            m_n42 = (GImage)GetChildAt(7);
            m_txt_title = (GTextField)GetChildAt(8);
            m_txt_time = (GTextField)GetChildAt(9);
            m_txt_reward = (GTextField)GetChildAt(10);
            m_list_item = (GList)GetChildComAt(11);
            m_item_mine = (UI_ArenaRewardItemSkin)GetChildComAt(12);
            m_btn_back = (GButton)GetChildComAt(13);
        }
    }
}