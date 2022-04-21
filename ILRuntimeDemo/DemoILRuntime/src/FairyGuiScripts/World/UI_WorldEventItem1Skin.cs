/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEventItem1Skin : GComponent
    {
        public GLoader m_img_bg;
        public GImage m_n15;
        public GButton m_img_icon;
        public GImage m_n14;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_time;
        public GButton m_btn_explore;
        public GButton m_btn_goto;
        public const string URL = "ui://63ubk2jodibid";

        public static UI_WorldEventItem1Skin CreateInstance()
        {
            return (UI_WorldEventItem1Skin)UIPackage.CreateComponet("World", "WorldEventItem1Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_n15 = (GImage)GetChildAt(1);
            m_img_icon = (GButton)GetChildComAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_txt_name = (GRichTextField)GetChildAt(4);
            m_txt_desc = (GRichTextField)GetChildAt(5);
            m_txt_time = (GRichTextField)GetChildAt(6);
            m_btn_explore = (GButton)GetChildComAt(7);
            m_btn_goto = (GButton)GetChildComAt(8);
        }
    }
}