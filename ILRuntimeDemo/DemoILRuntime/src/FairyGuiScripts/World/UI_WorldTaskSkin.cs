/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldTaskSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GLoader m_img_npc;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n17;
        public GImage m_n18;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_progress;
        public GList m_list_reward;
        public GButton m_btn;
        public GButton m_btn_ignore;
        public const string URL = "ui://63ubk2jodibir";

        public static UI_WorldTaskSkin CreateInstance()
        {
            return (UI_WorldTaskSkin)UIPackage.CreateComponet("World", "WorldTaskSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_img_npc = (GLoader)GetChildAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_n15 = (GImage)GetChildAt(4);
            m_n17 = (GImage)GetChildAt(5);
            m_n18 = (GImage)GetChildAt(6);
            m_txt_tip1 = (GTextField)GetChildAt(7);
            m_txt_tip2 = (GTextField)GetChildAt(8);
            m_txt_desc = (GRichTextField)GetChildAt(9);
            m_txt_progress = (GRichTextField)GetChildAt(10);
            m_list_reward = (GList)GetChildComAt(11);
            m_btn = (GButton)GetChildComAt(12);
            m_btn_ignore = (GButton)GetChildComAt(13);
        }
    }
}