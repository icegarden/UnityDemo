/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldShopSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GList m_list_item;
        public GList m_list_currency;
        public GRichTextField m_txt_time;
        public GButton m_btn_ignore;
        public const string URL = "ui://63ubk2jodibim";

        public static UI_WorldShopSkin CreateInstance()
        {
            return (UI_WorldShopSkin)UIPackage.CreateComponet("World", "WorldShopSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
            m_list_currency = (GList)GetChildComAt(3);
            m_txt_time = (GRichTextField)GetChildAt(4);
            m_btn_ignore = (GButton)GetChildComAt(5);
        }
    }
}