/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_ShopItemSkin : GComponent
    {
        public GImage m_n6;
        public GComponent m_item;
        public GLoader m_img_money;
        public GTextField m_txt_money;
        public GRichTextField m_txt_leftCount;
        public GRichTextField m_txt_discount;
        public GTextField m_txt_sellout;
        public const string URL = "ui://v22o2wamg7ded";

        public static UI_ShopItemSkin CreateInstance()
        {
            return (UI_ShopItemSkin)UIPackage.CreateComponet("Shop", "ShopItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n6 = (GImage)GetChildAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_img_money = (GLoader)GetChildAt(2);
            m_txt_money = (GTextField)GetChildAt(3);
            m_txt_leftCount = (GRichTextField)GetChildAt(4);
            m_txt_discount = (GRichTextField)GetChildAt(5);
            m_txt_sellout = (GTextField)GetChildAt(6);
        }
    }
}