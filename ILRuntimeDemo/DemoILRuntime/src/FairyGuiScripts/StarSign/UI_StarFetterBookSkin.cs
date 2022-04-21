/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarFetterBookSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLabel m_title;
        public GImage m_n14;
        public GImage m_n4;
        public GImage m_n17;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GList m_list_pet;
        public GList m_list_tab;
        public GButton m_btn_fetter;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public const string URL = "ui://xplmw3njho4vq";

        public static UI_StarFetterBookSkin CreateInstance()
        {
            return (UI_StarFetterBookSkin)UIPackage.CreateComponet("StarSign", "StarFetterBookSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_n14 = (GImage)GetChildAt(2);
            m_n4 = (GImage)GetChildAt(3);
            m_n17 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_list_pet = (GList)GetChildComAt(7);
            m_list_tab = (GList)GetChildComAt(8);
            m_btn_fetter = (GButton)GetChildComAt(9);
            m_img_bottom = (GLoader)GetChildAt(10);
            m_btn_back = (GButton)GetChildComAt(11);
            m_btn_left = (GButton)GetChildComAt(12);
            m_btn_right = (GButton)GetChildComAt(13);
        }
    }
}