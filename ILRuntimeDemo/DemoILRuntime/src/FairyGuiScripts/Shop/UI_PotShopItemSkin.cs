/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_PotShopItemSkin : GComponent
    {
        public GImage m_n3;
        public GLoader m_img_money;
        public GRichTextField m_txt_name;
        public GTextField m_txt_money;
        public GRichTextField m_txt_leftCount;
        public GRichTextField m_txt_limitTime;
        public GButton m_btn_tip;
        public GComponent m_item;
        public const string URL = "ui://v22o2wamycl75";

        public static UI_PotShopItemSkin CreateInstance()
        {
            return (UI_PotShopItemSkin)UIPackage.CreateComponet("Shop", "PotShopItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n3 = (GImage)GetChildAt(0);
            m_img_money = (GLoader)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_money = (GTextField)GetChildAt(3);
            m_txt_leftCount = (GRichTextField)GetChildAt(4);
            m_txt_limitTime = (GRichTextField)GetChildAt(5);
            m_btn_tip = (GButton)GetChildComAt(6);
            m_item = (GComponent)GetChildComAt(7);
        }
    }
}