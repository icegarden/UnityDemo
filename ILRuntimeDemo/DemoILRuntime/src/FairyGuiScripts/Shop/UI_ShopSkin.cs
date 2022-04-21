/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_ShopSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public UI_PotShopSkin m_view_pot;
        public UI_SubShopSkin m_view_sub;
        public GImage m_n14;
        public GImage m_n1;
        public GTextField m_txt_name;
        public GButton m_btn_shop;
        public GButton m_btn_scoreShop;
        public GButton m_btn_potShop;
        public GButton m_btn_back;
        public GList m_list_money;
        public const string URL = "ui://v22o2wamycl70";

        public static UI_ShopSkin CreateInstance()
        {
            return (UI_ShopSkin)UIPackage.CreateComponet("Shop", "ShopSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_view_pot = (UI_PotShopSkin)GetChildComAt(1);
            m_view_sub = (UI_SubShopSkin)GetChildComAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_n1 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_btn_shop = (GButton)GetChildComAt(6);
            m_btn_scoreShop = (GButton)GetChildComAt(7);
            m_btn_potShop = (GButton)GetChildComAt(8);
            m_btn_back = (GButton)GetChildComAt(9);
            m_list_money = (GList)GetChildComAt(10);
        }
    }
}