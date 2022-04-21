/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_BagSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg;
        public GLoader m_img_bg1;
        public GButton m_btn_equip;
        public GButton m_btn_material;
        public GButton m_btn_consume;
        public GButton m_btn_stone;
        public GButton m_btn_others;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n65;
        public GImage m_n69;
        public GTextField m_txt_title;
        public GTextField m_txt_bagCount;
        public GList m_list_item;
        public UI_DecomposeBtnGroup m_item_decompose;
        public GButton m_btn_addBagCount;
        public GButton m_btn_back;
        public GButton m_btn_dispose;
        public const string URL = "ui://e98lwrlopcju0";

        public static UI_BagSkin CreateInstance()
        {
            return (UI_BagSkin)UIPackage.CreateComponet("Bag", "BagSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bg1 = (GLoader)GetChildAt(1);
            m_btn_equip = (GButton)GetChildComAt(2);
            m_btn_material = (GButton)GetChildComAt(3);
            m_btn_consume = (GButton)GetChildComAt(4);
            m_btn_stone = (GButton)GetChildComAt(5);
            m_btn_others = (GButton)GetChildComAt(6);
            m_img_bg2 = (GLoader)GetChildAt(7);
            m_img_top = (GLoader)GetChildAt(8);
            m_n65 = (GImage)GetChildAt(9);
            m_n69 = (GImage)GetChildAt(10);
            m_txt_title = (GTextField)GetChildAt(11);
            m_txt_bagCount = (GTextField)GetChildAt(12);
            m_list_item = (GList)GetChildComAt(13);
            m_item_decompose = (UI_DecomposeBtnGroup)GetChildComAt(14);
            m_btn_addBagCount = (GButton)GetChildComAt(15);
            m_btn_back = (GButton)GetChildComAt(16);
            m_btn_dispose = (GButton)GetChildComAt(17);
        }
    }
}