/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemGetItemSkin : GComponent
    {
        public GImage m_n5;
        public GRichTextField m_txt_desc;
        public GButton m_btn_goto;
        public const string URL = "ui://e98lwrlopcju1c";

        public static UI_ItemGetItemSkin CreateInstance()
        {
            return (UI_ItemGetItemSkin)UIPackage.CreateComponet("Bag", "ItemGetItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n5 = (GImage)GetChildAt(0);
            m_txt_desc = (GRichTextField)GetChildAt(1);
            m_btn_goto = (GButton)GetChildComAt(2);
        }
    }
}