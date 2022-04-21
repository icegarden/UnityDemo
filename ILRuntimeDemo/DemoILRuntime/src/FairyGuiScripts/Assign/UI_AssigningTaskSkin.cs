/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssigningTaskSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GComponent m_con_avatar;
        public GImage m_n35;
        public GImage m_n36;
        public GImage m_n40;
        public GImage m_n41;
        public GImage m_n45;
        public GImage m_img_time;
        public GImage m_n54;
        public GImage m_img_dot0;
        public GImage m_img_dot1;
        public GImage m_img_dot2;
        public GTextField m_txt_timeTitle;
        public GTextField m_txt_time;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_exp;
        public GList m_list_explore;
        public GList m_list_reward;
        public GButton m_btn_take;
        public Transition m_exploring;
        public const string URL = "ui://e8jsnjd3gikd9";

        public static UI_AssigningTaskSkin CreateInstance()
        {
            return (UI_AssigningTaskSkin)UIPackage.CreateComponet("Assign", "AssigningTaskSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_con_avatar = (GComponent)GetChildComAt(2);
            m_n35 = (GImage)GetChildAt(3);
            m_n36 = (GImage)GetChildAt(4);
            m_n40 = (GImage)GetChildAt(5);
            m_n41 = (GImage)GetChildAt(6);
            m_n45 = (GImage)GetChildAt(7);
            m_img_time = (GImage)GetChildAt(8);
            m_n54 = (GImage)GetChildAt(9);
            m_img_dot0 = (GImage)GetChildAt(10);
            m_img_dot1 = (GImage)GetChildAt(11);
            m_img_dot2 = (GImage)GetChildAt(12);
            m_txt_timeTitle = (GTextField)GetChildAt(13);
            m_txt_time = (GTextField)GetChildAt(14);
            m_txt_tip1 = (GTextField)GetChildAt(15);
            m_txt_tip2 = (GTextField)GetChildAt(16);
            m_txt_exp = (GTextField)GetChildAt(17);
            m_list_explore = (GList)GetChildComAt(18);
            m_list_reward = (GList)GetChildComAt(19);
            m_btn_take = (GButton)GetChildComAt(20);
            m_exploring = GetTransitionAt(0);
        }
    }
}