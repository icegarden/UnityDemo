/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_KongMoBossSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_bottom;
        public GImage m_n16;
        public GComponent m_con_avatar;
        public GLabel m_title;
        public GTextField m_txt_time;
        public GButton m_btn_back;
        public GLoader m_img_center;
        public GImage m_n11;
        public GImage m_n12;
        public GTextField m_txt_tip1;
        public GTextField m_txt_challengeCount;
        public GList m_list_skill;
        public GList m_list_reward;
        public GButton m_btn_challenge;
        public GGroup m_gp_bottom;
        public const string URL = "ui://etkvbnyek73k9";

        public static UI_KongMoBossSkin CreateInstance()
        {
            return (UI_KongMoBossSkin)UIPackage.CreateComponet("Boss", "KongMoBossSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_n16 = (GImage)GetChildAt(2);
            m_con_avatar = (GComponent)GetChildComAt(3);
            m_title = (GLabel)GetChildComAt(4);
            m_txt_time = (GTextField)GetChildAt(5);
            m_btn_back = (GButton)GetChildComAt(6);
            m_img_center = (GLoader)GetChildAt(7);
            m_n11 = (GImage)GetChildAt(8);
            m_n12 = (GImage)GetChildAt(9);
            m_txt_tip1 = (GTextField)GetChildAt(10);
            m_txt_challengeCount = (GTextField)GetChildAt(11);
            m_list_skill = (GList)GetChildComAt(12);
            m_list_reward = (GList)GetChildComAt(13);
            m_btn_challenge = (GButton)GetChildComAt(14);
            m_gp_bottom = (GGroup)GetChildAt(15);
        }
    }
}