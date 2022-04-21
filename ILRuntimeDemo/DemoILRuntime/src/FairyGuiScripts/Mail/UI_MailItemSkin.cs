/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mail
{
    public partial class UI_MailItemSkin : GComponent
    {
        public GImage m_n0;
        public GLoader m_img_icon;
        public GRichTextField m_txt_title;
        public GRichTextField m_txt_time;
        public GTextField m_txt_unread;
        public const string URL = "ui://67xei01rkd9o1";

        public static UI_MailItemSkin CreateInstance()
        {
            return (UI_MailItemSkin)UIPackage.CreateComponet("Mail", "MailItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_txt_title = (GRichTextField)GetChildAt(2);
            m_txt_time = (GRichTextField)GetChildAt(3);
            m_txt_unread = (GTextField)GetChildAt(4);
        }
    }
}