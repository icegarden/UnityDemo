/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildTipSkin : GComponent
    {
        public Controller m_control;
        public GImage m_img_bg;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n11;
        public GImage m_n13;
        public GTextField m_txt_title1;
        public GTextField m_txt_msg0;
        public GTextField m_txt_msg1;
        public GTextField m_txt_title20;
        public GTextField m_txt_title21;
        public GTextField m_txt_value20;
        public GTextField m_txt_value21;
        public GTextField m_txt_title22;
        public GTextField m_txt_value22;
        public GRichTextField m_txt_msg2;
        public GRichTextField m_txt_msg3;
        public GTextField m_txt_msg20;
        public const string URL = "ui://tae9x4e9mde41k";

        public static UI_GuildTipSkin CreateInstance()
        {
            return (UI_GuildTipSkin)UIPackage.CreateComponet("Guild", "GuildTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_img_bg = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n11 = (GImage)GetChildAt(3);
            m_n13 = (GImage)GetChildAt(4);
            m_txt_title1 = (GTextField)GetChildAt(5);
            m_txt_msg0 = (GTextField)GetChildAt(6);
            m_txt_msg1 = (GTextField)GetChildAt(7);
            m_txt_title20 = (GTextField)GetChildAt(8);
            m_txt_title21 = (GTextField)GetChildAt(9);
            m_txt_value20 = (GTextField)GetChildAt(10);
            m_txt_value21 = (GTextField)GetChildAt(11);
            m_txt_title22 = (GTextField)GetChildAt(12);
            m_txt_value22 = (GTextField)GetChildAt(13);
            m_txt_msg2 = (GRichTextField)GetChildAt(14);
            m_txt_msg3 = (GRichTextField)GetChildAt(15);
            m_txt_msg20 = (GTextField)GetChildAt(16);
        }
    }
}