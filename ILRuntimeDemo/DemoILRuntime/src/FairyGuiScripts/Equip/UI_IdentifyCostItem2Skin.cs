/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_IdentifyCostItem2Skin : GComponent
    {
        public GImage m_n4;
        public GImage m_n1;
        public GRichTextField m_txt_count;
        public GLoader m_img_icon;
        public const string URL = "ui://5ch1xwvwsig2o";

        public static UI_IdentifyCostItem2Skin CreateInstance()
        {
            return (UI_IdentifyCostItem2Skin)UIPackage.CreateComponet("Equip", "IdentifyCostItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
        }
    }
}