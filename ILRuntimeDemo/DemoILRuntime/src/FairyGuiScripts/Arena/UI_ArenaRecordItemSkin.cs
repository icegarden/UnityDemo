/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRecordItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_result;
        public GImage m_n28;
        public GImage m_n29;
        public GImage m_n30;
        public GTextField m_txt_myName;
        public GRichTextField m_txt_myPower;
        public GTextField m_txt_enemyName;
        public GRichTextField m_txt_enemyPower;
        public GRichTextField m_txt_origin;
        public GRichTextField m_txt_time;
        public GList m_list_mine;
        public GList m_list_enemy;
        public GButton m_btn_data;
        public GButton m_btn_video;
        public GButton m_btn_share;
        public const string URL = "ui://m8qegzmncnj3a";

        public static UI_ArenaRecordItemSkin CreateInstance()
        {
            return (UI_ArenaRecordItemSkin)UIPackage.CreateComponet("Arena", "ArenaRecordItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_result = (GLoader)GetChildAt(1);
            m_n28 = (GImage)GetChildAt(2);
            m_n29 = (GImage)GetChildAt(3);
            m_n30 = (GImage)GetChildAt(4);
            m_txt_myName = (GTextField)GetChildAt(5);
            m_txt_myPower = (GRichTextField)GetChildAt(6);
            m_txt_enemyName = (GTextField)GetChildAt(7);
            m_txt_enemyPower = (GRichTextField)GetChildAt(8);
            m_txt_origin = (GRichTextField)GetChildAt(9);
            m_txt_time = (GRichTextField)GetChildAt(10);
            m_list_mine = (GList)GetChildComAt(11);
            m_list_enemy = (GList)GetChildComAt(12);
            m_btn_data = (GButton)GetChildComAt(13);
            m_btn_video = (GButton)GetChildComAt(14);
            m_btn_share = (GButton)GetChildComAt(15);
        }
    }
}