/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonShopItemSkin : GComponent
    {
        public GImage m_n7;
        public GImage m_n9;
        public GComponent m_item;
        public GLoader m_img_money;
        public GTextField m_txt_money;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_saleout;
        public GRichTextField m_txt_count;
        public const string URL = "ui://uwx2vhvssig22u";

        public static UI_DungeonShopItemSkin CreateInstance()
        {
            return (UI_DungeonShopItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonShopItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n7 = (GImage)GetChildAt(0);
            m_n9 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_img_money = (GLoader)GetChildAt(3);
            m_txt_money = (GTextField)GetChildAt(4);
            m_txt_name = (GRichTextField)GetChildAt(5);
            m_txt_saleout = (GRichTextField)GetChildAt(6);
            m_txt_count = (GRichTextField)GetChildAt(7);
        }
    }
}