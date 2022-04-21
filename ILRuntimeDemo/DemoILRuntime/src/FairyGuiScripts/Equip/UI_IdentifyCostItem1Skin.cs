/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_IdentifyCostItem1Skin : GComponent
    {
        public GImage m_n0;
        public GImage m_n1;
        public GRichTextField m_txt_count;
        public GLoader m_img_icon;
        public const string URL = "ui://5ch1xwvwsig2m";

        public static UI_IdentifyCostItem1Skin CreateInstance()
        {
            return (UI_IdentifyCostItem1Skin)UIPackage.CreateComponet("Equip", "IdentifyCostItem1Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
        }
    }
}