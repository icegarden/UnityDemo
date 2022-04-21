/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pata
{
    public partial class UI_PataSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_bg_road1;
        public GLoader m_bg_road2;
        public GLoader m_bg_list1;
        public GLoader m_bg_list2;
        public GList m_list_pata;
        public GLabel m_title;
        public GImage m_n8;
        public GImage m_bg_pass;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GTextField m_txt_list_title;
        public GTextField m_txt_pass;
        public const string URL = "ui://29ak73mnh9kj0";

        public static UI_PataSkin CreateInstance()
        {
            return (UI_PataSkin)UIPackage.CreateComponet("Pata", "PataSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_bg_road1 = (GLoader)GetChildAt(1);
            m_bg_road2 = (GLoader)GetChildAt(2);
            m_bg_list1 = (GLoader)GetChildAt(3);
            m_bg_list2 = (GLoader)GetChildAt(4);
            m_list_pata = (GList)GetChildComAt(5);
            m_title = (GLabel)GetChildComAt(6);
            m_n8 = (GImage)GetChildAt(7);
            m_bg_pass = (GImage)GetChildAt(8);
            m_img_bottom = (GLoader)GetChildAt(9);
            m_btn_back = (GButton)GetChildComAt(10);
            m_txt_list_title = (GTextField)GetChildAt(11);
            m_txt_pass = (GTextField)GetChildAt(12);
        }
    }
}