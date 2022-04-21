/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_SuffixItemSkin : GComponent
    {
        public GLoader m_img_quality;
        public GRichTextField m_txt_qualityRate;
        public GRichTextField m_txt_cout;
        public GRichTextField m_txt_countRate;
        public const string URL = "ui://5ch1xwvwl1me3d";

        public static UI_SuffixItemSkin CreateInstance()
        {
            return (UI_SuffixItemSkin)UIPackage.CreateComponet("Equip", "SuffixItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_quality = (GLoader)GetChildAt(0);
            m_txt_qualityRate = (GRichTextField)GetChildAt(1);
            m_txt_cout = (GRichTextField)GetChildAt(2);
            m_txt_countRate = (GRichTextField)GetChildAt(3);
        }
    }
}