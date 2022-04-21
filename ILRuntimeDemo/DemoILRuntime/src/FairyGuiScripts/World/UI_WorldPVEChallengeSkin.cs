/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldPVEChallengeSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GLoader m_img_icon;
        public GImage m_n35;
        public GImage m_n34;
        public GImage m_n30;
        public GImage m_n31;
        public GTextField m_txt_power;
        public GTextField m_txt_tip1;
        public GList m_list_head;
        public GList m_list_winReward;
        public GButton m_btn_challenge;
        public GButton m_btn_ignore;
        public const string URL = "ui://63ubk2jodibih";

        public static UI_WorldPVEChallengeSkin CreateInstance()
        {
            return (UI_WorldPVEChallengeSkin)UIPackage.CreateComponet("World", "WorldPVEChallengeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n35 = (GImage)GetChildAt(3);
            m_n34 = (GImage)GetChildAt(4);
            m_n30 = (GImage)GetChildAt(5);
            m_n31 = (GImage)GetChildAt(6);
            m_txt_power = (GTextField)GetChildAt(7);
            m_txt_tip1 = (GTextField)GetChildAt(8);
            m_list_head = (GList)GetChildComAt(9);
            m_list_winReward = (GList)GetChildComAt(10);
            m_btn_challenge = (GButton)GetChildComAt(11);
            m_btn_ignore = (GButton)GetChildComAt(12);
        }
    }
}