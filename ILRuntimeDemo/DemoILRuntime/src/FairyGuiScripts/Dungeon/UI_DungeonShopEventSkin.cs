/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonShopEventSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GRichTextField m_txt_desc;
        public GList m_list_item;
        public GList m_list_currency;
        public GButton m_btn_close;
        public const string URL = "ui://uwx2vhvssig22t";

        public static UI_DungeonShopEventSkin CreateInstance()
        {
            return (UI_DungeonShopEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonShopEventSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_txt_desc = (GRichTextField)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_list_currency = (GList)GetChildComAt(4);
            m_btn_close = (GButton)GetChildComAt(5);
        }
    }
}