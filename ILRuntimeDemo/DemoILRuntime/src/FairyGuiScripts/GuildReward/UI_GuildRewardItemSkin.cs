/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardItemSkin : GComponent
    {
        public Controller m_control;
        public GLoader m_img_bg;
        public GLoader m_img_frame;
        public GImage m_n8;
        public GImage m_n12;
        public GImage m_n16;
        public GImage m_n17;
        public GImage m_n10;
        public GImage m_n13;
        public GImage m_n22;
        public GLoader m_img_icon;
        public GTextField m_txt_title;
        public GTextField m_txt_cd;
        public GTextField m_txt_count;
        public GTextField m_txt_title1;
        public GTextField m_txt_lock;
        public GButton m_btn_enter;
        public GList m_list_reward;
        public const string URL = "ui://l0x7u1wbo1ucj";

        public static UI_GuildRewardItemSkin CreateInstance()
        {
            return (UI_GuildRewardItemSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_frame = (GLoader)GetChildAt(1);
            m_n8 = (GImage)GetChildAt(2);
            m_n12 = (GImage)GetChildAt(3);
            m_n16 = (GImage)GetChildAt(4);
            m_n17 = (GImage)GetChildAt(5);
            m_n10 = (GImage)GetChildAt(6);
            m_n13 = (GImage)GetChildAt(7);
            m_n22 = (GImage)GetChildAt(8);
            m_img_icon = (GLoader)GetChildAt(9);
            m_txt_title = (GTextField)GetChildAt(10);
            m_txt_cd = (GTextField)GetChildAt(11);
            m_txt_count = (GTextField)GetChildAt(12);
            m_txt_title1 = (GTextField)GetChildAt(13);
            m_txt_lock = (GTextField)GetChildAt(14);
            m_btn_enter = (GButton)GetChildComAt(15);
            m_list_reward = (GList)GetChildComAt(16);
        }
    }
}