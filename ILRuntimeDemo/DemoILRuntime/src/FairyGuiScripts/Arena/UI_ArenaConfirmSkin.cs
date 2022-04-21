/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaConfirmSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n26;
        public GImage m_n24;
        public GImage m_n25;
        public GImage m_n17;
        public GImage m_n18;
        public GImage m_n19;
        public GImage m_n20;
        public GImage m_n21;
        public GImage m_n22;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_winScore;
        public GTextField m_txt_failScore;
        public GList m_list_head;
        public GList m_list_reward;
        public GButton m_btn_challenge;
        public const string URL = "ui://m8qegzmncnj37";

        public static UI_ArenaConfirmSkin CreateInstance()
        {
            return (UI_ArenaConfirmSkin)UIPackage.CreateComponet("Arena", "ArenaConfirmSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n26 = (GImage)GetChildAt(1);
            m_n24 = (GImage)GetChildAt(2);
            m_n25 = (GImage)GetChildAt(3);
            m_n17 = (GImage)GetChildAt(4);
            m_n18 = (GImage)GetChildAt(5);
            m_n19 = (GImage)GetChildAt(6);
            m_n20 = (GImage)GetChildAt(7);
            m_n21 = (GImage)GetChildAt(8);
            m_n22 = (GImage)GetChildAt(9);
            m_txt_tip2 = (GTextField)GetChildAt(10);
            m_txt_tip3 = (GTextField)GetChildAt(11);
            m_txt_winScore = (GTextField)GetChildAt(12);
            m_txt_failScore = (GTextField)GetChildAt(13);
            m_list_head = (GList)GetChildComAt(14);
            m_list_reward = (GList)GetChildComAt(15);
            m_btn_challenge = (GButton)GetChildComAt(16);
        }
    }
}