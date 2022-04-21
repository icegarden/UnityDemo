/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEventInfoSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GLoader m_img_icon;
        public GImage m_n13;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n16;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_desc;
        public GList m_list_reward;
        public GButton m_btn;
        public GRichTextField m_txt_time;
        public const string URL = "ui://63ubk2jodibie";

        public static UI_WorldEventInfoSkin CreateInstance()
        {
            return (UI_WorldEventInfoSkin)UIPackage.CreateComponet("World", "WorldEventInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n13 = (GImage)GetChildAt(3);
            m_n14 = (GImage)GetChildAt(4);
            m_n15 = (GImage)GetChildAt(5);
            m_n16 = (GImage)GetChildAt(6);
            m_txt_tip1 = (GTextField)GetChildAt(7);
            m_txt_tip2 = (GTextField)GetChildAt(8);
            m_txt_desc = (GRichTextField)GetChildAt(9);
            m_list_reward = (GList)GetChildComAt(10);
            m_btn = (GButton)GetChildComAt(11);
            m_txt_time = (GRichTextField)GetChildAt(12);
        }
    }
}