/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemTipsViewSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GComponent m_item;
        public GImage m_n27;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_count;
        public GList m_list_use;
        public GButton m_btn_share;
        public GButton m_btn_get;
        public GButton m_btn_use;
        public GButton m_btn_decompose;
        public GButton m_btn_compose;
        public const string URL = "ui://e98lwrloqncm26";

        public static UI_ItemTipsViewSkin CreateInstance()
        {
            return (UI_ItemTipsViewSkin)UIPackage.CreateComponet("Bag", "ItemTipsViewSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_n27 = (GImage)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
            m_txt_name = (GRichTextField)GetChildAt(4);
            m_txt_type = (GTextField)GetChildAt(5);
            m_txt_count = (GTextField)GetChildAt(6);
            m_list_use = (GList)GetChildComAt(7);
            m_btn_share = (GButton)GetChildComAt(8);
            m_btn_get = (GButton)GetChildComAt(9);
            m_btn_use = (GButton)GetChildComAt(10);
            m_btn_decompose = (GButton)GetChildComAt(11);
            m_btn_compose = (GButton)GetChildComAt(12);
        }
    }
}