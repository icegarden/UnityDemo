/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_RecommendStoneCombineItemSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n6;
        public GImage m_n11;
        public GRichTextField m_txt_effect;
        public GRichTextField m_txt_count;
        public GList m_list_item;
        public UI_StoneCombineNameItemSkin m_item_name;
        public const string URL = "ui://em095moert0b19";

        public static UI_RecommendStoneCombineItemSkin CreateInstance()
        {
            return (UI_RecommendStoneCombineItemSkin)UIPackage.CreateComponet("Pet", "RecommendStoneCombineItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n6 = (GImage)GetChildAt(1);
            m_n11 = (GImage)GetChildAt(2);
            m_txt_effect = (GRichTextField)GetChildAt(3);
            m_txt_count = (GRichTextField)GetChildAt(4);
            m_list_item = (GList)GetChildComAt(5);
            m_item_name = (UI_StoneCombineNameItemSkin)GetChildComAt(6);
        }
    }
}