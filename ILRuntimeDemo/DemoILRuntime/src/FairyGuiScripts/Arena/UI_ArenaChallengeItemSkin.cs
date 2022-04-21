/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaChallengeItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public UI_PlayerHead1Skin m_item_head;
        public GImage m_n23;
        public GImage m_n17;
        public GImage m_n12;
        public GLoader m_img_icon;
        public GRichTextField m_txt_count;
        public GRichTextField m_txt_score;
        public GTextField m_txt_name;
        public GTextField m_txt_power;
        public GButton m_btn_challenge;
        public const string URL = "ui://m8qegzmncnj35";

        public static UI_ArenaChallengeItemSkin CreateInstance()
        {
            return (UI_ArenaChallengeItemSkin)UIPackage.CreateComponet("Arena", "ArenaChallengeItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_item_head = (UI_PlayerHead1Skin)GetChildComAt(1);
            m_n23 = (GImage)GetChildAt(2);
            m_n17 = (GImage)GetChildAt(3);
            m_n12 = (GImage)GetChildAt(4);
            m_img_icon = (GLoader)GetChildAt(5);
            m_txt_count = (GRichTextField)GetChildAt(6);
            m_txt_score = (GRichTextField)GetChildAt(7);
            m_txt_name = (GTextField)GetChildAt(8);
            m_txt_power = (GTextField)GetChildAt(9);
            m_btn_challenge = (GButton)GetChildComAt(10);
        }
    }
}