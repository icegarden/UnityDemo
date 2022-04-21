/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildChangeNoticeSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GTextInput m_txt_notice;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n7;
        public const string URL = "ui://tae9x4e9yfna19";

        public static UI_GuildChangeNoticeSkin CreateInstance()
        {
            return (UI_GuildChangeNoticeSkin)UIPackage.CreateComponet("Guild", "GuildChangeNoticeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_txt_notice = (GTextInput)GetChildAt(2);
            m_btn_confirm = (GButton)GetChildComAt(3);
            m_btn_cancel = (GButton)GetChildComAt(4);
            m_n7 = (GGroup)GetChildAt(5);
        }
    }
}