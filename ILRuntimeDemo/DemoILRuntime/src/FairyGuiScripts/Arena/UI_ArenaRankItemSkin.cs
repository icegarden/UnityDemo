/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRankItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GImage m_n37;
        public UI_PlayerHead1Skin m_item_head;
        public GLoader m_img_rank;
        public GLoader m_img_level;
        public GTextField m_txt_rank;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_score;
        public GTextField m_txt_tip;
        public const string URL = "ui://m8qegzmncnj3f";

        public static UI_ArenaRankItemSkin CreateInstance()
        {
            return (UI_ArenaRankItemSkin)UIPackage.CreateComponet("Arena", "ArenaRankItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_n37 = (GImage)GetChildAt(1);
            m_item_head = (UI_PlayerHead1Skin)GetChildComAt(2);
            m_img_rank = (GLoader)GetChildAt(3);
            m_img_level = (GLoader)GetChildAt(4);
            m_txt_rank = (GTextField)GetChildAt(5);
            m_txt_name = (GRichTextField)GetChildAt(6);
            m_txt_score = (GRichTextField)GetChildAt(7);
            m_txt_tip = (GTextField)GetChildAt(8);
        }
    }
}