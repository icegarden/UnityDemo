/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_img_bg;
        public GImage m_n14;
        public GLoader m_img_icon;
        public GComponent m_item_star1;
        public GComponent m_item_star2;
        public GComponent m_item_star3;
        public GComponent m_item_star4;
        public GComponent m_item_star5;
        public GRichTextField m_txt_name;
        public GTextField m_txt_level;
        public const string URL = "ui://rqnkl6749hyno";

        public static UI_HalidomItemSkin CreateInstance()
        {
            return (UI_HalidomItemSkin)UIPackage.CreateComponet("Halidom", "HalidomItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GImage)GetChildAt(0);
            m_n14 = (GImage)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_item_star1 = (GComponent)GetChildComAt(3);
            m_item_star2 = (GComponent)GetChildComAt(4);
            m_item_star3 = (GComponent)GetChildComAt(5);
            m_item_star4 = (GComponent)GetChildComAt(6);
            m_item_star5 = (GComponent)GetChildComAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
            m_txt_level = (GTextField)GetChildAt(9);
        }
    }
}