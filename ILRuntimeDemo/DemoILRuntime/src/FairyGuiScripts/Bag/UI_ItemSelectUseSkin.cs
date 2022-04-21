/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemSelectUseSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n34;
        public GImage m_n35;
        public GList m_list_item;
        public GTextInput m_txt_useCount;
        public GRichTextField m_txt_get;
        public GButton m_btn_sub;
        public GButton m_btn_add;
        public GSlider m_btn_slide;
        public GButton m_btn_cancel;
        public GButton m_btn_use;
        public const string URL = "ui://e98lwrlopcju1g";

        public static UI_ItemSelectUseSkin CreateInstance()
        {
            return (UI_ItemSelectUseSkin)UIPackage.CreateComponet("Bag", "ItemSelectUseSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n34 = (GImage)GetChildAt(1);
            m_n35 = (GImage)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_txt_useCount = (GTextInput)GetChildAt(4);
            m_txt_get = (GRichTextField)GetChildAt(5);
            m_btn_sub = (GButton)GetChildComAt(6);
            m_btn_add = (GButton)GetChildComAt(7);
            m_btn_slide = (GSlider)GetChildComAt(8);
            m_btn_cancel = (GButton)GetChildComAt(9);
            m_btn_use = (GButton)GetChildComAt(10);
        }
    }
}