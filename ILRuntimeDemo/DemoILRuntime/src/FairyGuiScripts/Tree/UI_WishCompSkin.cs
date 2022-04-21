/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_WishCompSkin : GComponent
    {
        public GButton m_btn_preview;
        public GImage m_n37;
        public GImage m_n26;
        public GTextField m_txt_lv;
        public GTextField m_txt_title0;
        public GButton m_btn_breach;
        public GComponent m_item_cost;
        public GList m_list_pro;
        public const string URL = "ui://jj5xd8f5mde4o";

        public static UI_WishCompSkin CreateInstance()
        {
            return (UI_WishCompSkin)UIPackage.CreateComponet("Tree", "WishCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_btn_preview = (GButton)GetChildComAt(0);
            m_n37 = (GImage)GetChildAt(1);
            m_n26 = (GImage)GetChildAt(2);
            m_txt_lv = (GTextField)GetChildAt(3);
            m_txt_title0 = (GTextField)GetChildAt(4);
            m_btn_breach = (GButton)GetChildComAt(5);
            m_item_cost = (GComponent)GetChildComAt(6);
            m_list_pro = (GList)GetChildComAt(7);
        }
    }
}