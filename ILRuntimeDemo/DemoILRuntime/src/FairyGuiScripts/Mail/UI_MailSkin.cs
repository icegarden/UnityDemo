/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mail
{
    public partial class UI_MailSkin : GComponent
    {
        public GLoader m_img_bg1;
        public GLoader m_img_bg2;
        public GList m_list_item;
        public GButton m_btn_take;
        public GButton m_btn_delete;
        public GButton m_btn_back;
        public GLabel m_title;
        public const string URL = "ui://67xei01rkd9o0";

        public static UI_MailSkin CreateInstance()
        {
            return (UI_MailSkin)UIPackage.CreateComponet("Mail", "MailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg1 = (GLoader)GetChildAt(0);
            m_img_bg2 = (GLoader)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
            m_btn_take = (GButton)GetChildComAt(3);
            m_btn_delete = (GButton)GetChildComAt(4);
            m_btn_back = (GButton)GetChildComAt(5);
            m_title = (GLabel)GetChildComAt(6);
        }
    }
}