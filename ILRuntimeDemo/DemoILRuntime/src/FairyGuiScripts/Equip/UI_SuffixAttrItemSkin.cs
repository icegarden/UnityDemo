/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_SuffixAttrItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_tab;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public const string URL = "ui://5ch1xwvwl1me3g";

        public static UI_SuffixAttrItemSkin CreateInstance()
        {
            return (UI_SuffixAttrItemSkin)UIPackage.CreateComponet("Equip", "SuffixAttrItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_tab = (GLoader)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_value = (GRichTextField)GetChildAt(3);
        }
    }
}