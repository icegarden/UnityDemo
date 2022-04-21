/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ItemGetwaySkin : GComponent
    {
        public GLabel m_bg;
        public GComponent m_item;
        public GList m_list_get;
        public GRichTextField m_txt_name;
        public GTextField m_txt_type;
        public GTextField m_txt_count;
        public const string URL = "ui://e98lwrlopcju1b";

        public static UI_ItemGetwaySkin CreateInstance()
        {
            return (UI_ItemGetwaySkin)UIPackage.CreateComponet("Bag", "ItemGetwaySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_list_get = (GList)GetChildComAt(2);
            m_txt_name = (GRichTextField)GetChildAt(3);
            m_txt_type = (GTextField)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
        }
    }
}