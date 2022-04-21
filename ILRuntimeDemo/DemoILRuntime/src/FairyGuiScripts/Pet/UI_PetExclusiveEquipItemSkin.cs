/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetExclusiveEquipItemSkin : GComponent
    {
        public GRichTextField m_txt_desc;
        public const string URL = "ui://em095moesig26";

        public static UI_PetExclusiveEquipItemSkin CreateInstance()
        {
            return (UI_PetExclusiveEquipItemSkin)UIPackage.CreateComponet("Pet", "PetExclusiveEquipItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_desc = (GRichTextField)GetChildAt(0);
        }
    }
}