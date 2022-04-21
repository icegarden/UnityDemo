/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mission
{
    public partial class UI_MissionSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GLoader m_img_bg1;
        public GButton m_btn_daily;
        public GButton m_btn_weekly;
        public GButton m_btn_main;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n37;
        public GList m_list_item;
        public GTextField m_title;
        public GButton m_btn_back;
        public GImage m_n40;
        public GImage m_n41;
        public GProgressBar m_pb_count;
        public GImage m_n11;
        public UI_MissionRewardItemSkin m_reward0;
        public UI_MissionRewardItemSkin m_reward1;
        public UI_MissionRewardItemSkin m_reward2;
        public UI_MissionRewardItemSkin m_reward3;
        public UI_MissionRewardItemSkin m_reward4;
        public GTextField m_n26;
        public GTextField m_txt_refreshTIme;
        public GGroup m_gp_box;
        public const string URL = "ui://ew6i1be3sirw0";

        public static UI_MissionSkin CreateInstance()
        {
            return (UI_MissionSkin)UIPackage.CreateComponet("Mission", "MissionSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_btn_daily = (GButton)GetChildComAt(2);
            m_btn_weekly = (GButton)GetChildComAt(3);
            m_btn_main = (GButton)GetChildComAt(4);
            m_img_bg2 = (GLoader)GetChildAt(5);
            m_img_top = (GLoader)GetChildAt(6);
            m_n37 = (GImage)GetChildAt(7);
            m_list_item = (GList)GetChildComAt(8);
            m_title = (GTextField)GetChildAt(9);
            m_btn_back = (GButton)GetChildComAt(10);
            m_n40 = (GImage)GetChildAt(11);
            m_n41 = (GImage)GetChildAt(12);
            m_pb_count = (GProgressBar)GetChildComAt(13);
            m_n11 = (GImage)GetChildAt(14);
            m_reward0 = (UI_MissionRewardItemSkin)GetChildComAt(15);
            m_reward1 = (UI_MissionRewardItemSkin)GetChildComAt(16);
            m_reward2 = (UI_MissionRewardItemSkin)GetChildComAt(17);
            m_reward3 = (UI_MissionRewardItemSkin)GetChildComAt(18);
            m_reward4 = (UI_MissionRewardItemSkin)GetChildComAt(19);
            m_n26 = (GTextField)GetChildAt(20);
            m_txt_refreshTIme = (GTextField)GetChildAt(21);
            m_gp_box = (GGroup)GetChildAt(22);
        }
    }
}