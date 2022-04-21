/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildAlertSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public GImage m_n13;
        public GList m_list_item;
        public GTextField m_txt_msg;
        public GTextField m_txt_count;
        public GTextField m_txt0;
        public GTextField m_txt1;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n5;
        public const string URL = "ui://tae9x4e9mde41j";

        public static UI_GuildAlertSkin CreateInstance()
        {
            return (UI_GuildAlertSkin)UIPackage.CreateComponet("Guild", "GuildAlertSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n13 = (GImage)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
            m_txt_msg = (GTextField)GetChildAt(3);
            m_txt_count = (GTextField)GetChildAt(4);
            m_txt0 = (GTextField)GetChildAt(5);
            m_txt1 = (GTextField)GetChildAt(6);
            m_btn_confirm = (GButton)GetChildComAt(7);
            m_btn_cancel = (GButton)GetChildComAt(8);
            m_n5 = (GGroup)GetChildAt(9);
        }
    }
}