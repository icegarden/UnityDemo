/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldMiningItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GImage m_n15;
        public GButton m_img_icon;
        public GImage m_n14;
        public GTextField m_txt_name;
        public GRichTextField m_txt_state;
        public GTextField m_txt_speed;
        public GTextField m_txt_guildSpeed;
        public GRichTextField m_txt_time;
        public GButton m_btn_occupy;
        public const string URL = "ui://63ubk2jodibiu";

        public static UI_WorldMiningItemSkin CreateInstance()
        {
            return (UI_WorldMiningItemSkin)UIPackage.CreateComponet("World", "WorldMiningItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_n15 = (GImage)GetChildAt(1);
            m_img_icon = (GButton)GetChildComAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_txt_name = (GTextField)GetChildAt(4);
            m_txt_state = (GRichTextField)GetChildAt(5);
            m_txt_speed = (GTextField)GetChildAt(6);
            m_txt_guildSpeed = (GTextField)GetChildAt(7);
            m_txt_time = (GRichTextField)GetChildAt(8);
            m_btn_occupy = (GButton)GetChildComAt(9);
        }
    }
}