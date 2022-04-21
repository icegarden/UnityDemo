/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldRewardSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GImage m_n14;
        public GImage m_n15;
        public GLoader m_img_icon;
        public GTextField m_txt_tip1;
        public GList m_list_reward;
        public GButton m_btn_take;
        public GButton m_btn_ignore;
        public GTextField m_txt_cost;
        public GList m_list_cost;
        public const string URL = "ui://63ubk2jodibis";

        public static UI_WorldRewardSkin CreateInstance()
        {
            return (UI_WorldRewardSkin)UIPackage.CreateComponet("World", "WorldRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_n14 = (GImage)GetChildAt(2);
            m_n15 = (GImage)GetChildAt(3);
            m_img_icon = (GLoader)GetChildAt(4);
            m_txt_tip1 = (GTextField)GetChildAt(5);
            m_list_reward = (GList)GetChildComAt(6);
            m_btn_take = (GButton)GetChildComAt(7);
            m_btn_ignore = (GButton)GetChildComAt(8);
            m_txt_cost = (GTextField)GetChildAt(9);
            m_list_cost = (GList)GetChildComAt(10);
        }
    }
}