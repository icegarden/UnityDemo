/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneSlot2Skin : GComponent
    {
        public Controller m_state;
        public GComponent m_item;
        public GGraph m_n2;
        public GTextField m_txt_level;
        public GTextField m_txt_equiped;
        public const string URL = "ui://em095moert0b1a";

        public static UI_PetStoneSlot2Skin CreateInstance()
        {
            return (UI_PetStoneSlot2Skin)UIPackage.CreateComponet("Pet", "PetStoneSlot2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_n2 = (GGraph)GetChildAt(1);
            m_txt_level = (GTextField)GetChildAt(2);
            m_txt_equiped = (GTextField)GetChildAt(3);
        }
    }
}