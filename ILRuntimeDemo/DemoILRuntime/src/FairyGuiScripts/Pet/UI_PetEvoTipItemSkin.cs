/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvoTipItemSkin : GComponent
    {
        public GImage m_n0;
        public GRichTextField m_txt_tip;
        public const string URL = "ui://em095moefasib8";

        public static UI_PetEvoTipItemSkin CreateInstance()
        {
            return (UI_PetEvoTipItemSkin)UIPackage.CreateComponet("Pet", "PetEvoTipItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_txt_tip = (GRichTextField)GetChildAt(1);
        }
    }
}