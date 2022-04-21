/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_AddBagCountSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n15;
        public GTextField m_txt_tip;
        public GRichTextField m_txt_desc;
        public GComponent m_item;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public const string URL = "ui://e98lwrlopcjuz";

        public static UI_AddBagCountSkin CreateInstance()
        {
            return (UI_AddBagCountSkin)UIPackage.CreateComponet("Bag", "AddBagCountSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n15 = (GImage)GetChildAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
            m_item = (GComponent)GetChildComAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_cancel = (GButton)GetChildComAt(6);
        }
    }
}