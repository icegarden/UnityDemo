/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mail
{
    public partial class UI_MailContentSkin : GComponent
    {
        public GLabel m_bg;
        public GTextField m_n1;
        public GTextField m_n2;
        public GRichTextField m_txt_title;
        public GRichTextField m_txt_time;
        public GLabel m_txt_content;
        public GButton m_btn_take;
        public GButton m_btn_delete;
        public GImage m_n7;
        public GTextField m_n9;
        public GTextField m_txt_token;
        public GList m_list_rewards;
        public GGroup m_gp_attach;
        public GGroup m_n14;
        public const string URL = "ui://67xei01rkd9o2";

        public static UI_MailContentSkin CreateInstance()
        {
            return (UI_MailContentSkin)UIPackage.CreateComponet("Mail", "MailContentSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GTextField)GetChildAt(1);
            m_n2 = (GTextField)GetChildAt(2);
            m_txt_title = (GRichTextField)GetChildAt(3);
            m_txt_time = (GRichTextField)GetChildAt(4);
            m_txt_content = (GLabel)GetChildComAt(5);
            m_btn_take = (GButton)GetChildComAt(6);
            m_btn_delete = (GButton)GetChildComAt(7);
            m_n7 = (GImage)GetChildAt(8);
            m_n9 = (GTextField)GetChildAt(9);
            m_txt_token = (GTextField)GetChildAt(10);
            m_list_rewards = (GList)GetChildComAt(11);
            m_gp_attach = (GGroup)GetChildAt(12);
            m_n14 = (GGroup)GetChildAt(13);
        }
    }
}