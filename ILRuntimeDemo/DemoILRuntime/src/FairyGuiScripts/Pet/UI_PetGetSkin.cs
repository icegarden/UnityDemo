/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetGetSkin : GComponent
    {
        public GGraph m_bg;
        public GButton m_btn_skip;
        public UI_PetCardItemSkin m_card;
        public const string URL = "ui://em095moert0bd";

        public static UI_PetGetSkin CreateInstance()
        {
            return (UI_PetGetSkin)UIPackage.CreateComponet("Pet", "PetGetSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GGraph)GetChildAt(0);
            m_btn_skip = (GButton)GetChildComAt(1);
            m_card = (UI_PetCardItemSkin)GetChildComAt(2);
        }
    }
}