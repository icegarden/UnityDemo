/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg_base;
        public GLoader m_bg_chip;
        public GLoader m_img_bottom;
        public GLabel m_txt_title;
        public GList m_list_chip;
        public GList m_list_item;
        public GButton m_btn_back;
        public GButton m_btn_base;
        public GButton m_btn_chip;
        public GButton m_btn_book;
        public GComboBox m_btn_filter;
        public GComboBox m_btn_bookFilter;
        public const string URL = "ui://rqnkl674q5d40";

        public static UI_HalidomSkin CreateInstance()
        {
            return (UI_HalidomSkin)UIPackage.CreateComponet("Halidom", "HalidomSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg_base = (GLoader)GetChildAt(0);
            m_bg_chip = (GLoader)GetChildAt(1);
            m_img_bottom = (GLoader)GetChildAt(2);
            m_txt_title = (GLabel)GetChildComAt(3);
            m_list_chip = (GList)GetChildComAt(4);
            m_list_item = (GList)GetChildComAt(5);
            m_btn_back = (GButton)GetChildComAt(6);
            m_btn_base = (GButton)GetChildComAt(7);
            m_btn_chip = (GButton)GetChildComAt(8);
            m_btn_book = (GButton)GetChildComAt(9);
            m_btn_filter = (GComboBox)GetChildComAt(10);
            m_btn_bookFilter = (GComboBox)GetChildComAt(11);
        }
    }
}