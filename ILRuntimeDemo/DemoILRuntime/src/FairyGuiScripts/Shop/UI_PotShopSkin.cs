/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_PotShopSkin : GComponent
    {
        public GImage m_n2;
        public GTextField m_txt_discount;
        public GTextField m_txt_refreshTime;
        public GButton m_btn_welfare;
        public GList m_list_item;
        public const string URL = "ui://v22o2wamycl73";

        public static UI_PotShopSkin CreateInstance()
        {
            return (UI_PotShopSkin)UIPackage.CreateComponet("Shop", "PotShopSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_txt_discount = (GTextField)GetChildAt(1);
            m_txt_refreshTime = (GTextField)GetChildAt(2);
            m_btn_welfare = (GButton)GetChildComAt(3);
            m_list_item = (GList)GetChildComAt(4);
        }
    }
}