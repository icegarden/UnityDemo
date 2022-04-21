/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildMailSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GImage m_n6;
        public GTextInput m_txt_title;
        public GTextInput m_txt_desc;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n5;
        public const string URL = "ui://tae9x4e9yfna1a";

        public static UI_GuildMailSkin CreateInstance()
        {
            return (UI_GuildMailSkin)UIPackage.CreateComponet("Guild", "GuildMailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n6 = (GImage)GetChildAt(2);
            m_txt_title = (GTextInput)GetChildAt(3);
            m_txt_desc = (GTextInput)GetChildAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_cancel = (GButton)GetChildComAt(6);
            m_n5 = (GGroup)GetChildAt(7);
        }
    }
}