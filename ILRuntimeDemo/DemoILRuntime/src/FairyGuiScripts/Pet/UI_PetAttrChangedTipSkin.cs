/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetAttrChangedTipSkin : GComponent
    {
        public GRichTextField m_txt_tip;
        public const string URL = "ui://em095moeh46cap";

        public static UI_PetAttrChangedTipSkin CreateInstance()
        {
            return (UI_PetAttrChangedTipSkin)UIPackage.CreateComponet("Pet", "PetAttrChangedTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_tip = (GRichTextField)GetChildAt(0);
        }
    }
}