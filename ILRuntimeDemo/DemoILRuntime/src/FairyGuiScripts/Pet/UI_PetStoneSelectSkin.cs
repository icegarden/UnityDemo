/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneSelectSkin : GComponent
    {
        public Controller m_state;
        public GComponent m_n0;
        public GImage m_n12;
        public GImage m_n14;
        public GTextField m_txt_tip;
        public GComboBox m_btn_filter;
        public UI_PetStoneTipsSkin m_tip_equiped;
        public UI_PetStoneTipsSkin m_tip_replace;
        public GList m_list_stone;
        public GList m_list_get;
        public const string URL = "ui://em095moert0bx";

        public static UI_PetStoneSelectSkin CreateInstance()
        {
            return (UI_PetStoneSelectSkin)UIPackage.CreateComponet("Pet", "PetStoneSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n0 = (GComponent)GetChildComAt(0);
            m_n12 = (GImage)GetChildAt(1);
            m_n14 = (GImage)GetChildAt(2);
            m_txt_tip = (GTextField)GetChildAt(3);
            m_btn_filter = (GComboBox)GetChildComAt(4);
            m_tip_equiped = (UI_PetStoneTipsSkin)GetChildComAt(5);
            m_tip_replace = (UI_PetStoneTipsSkin)GetChildComAt(6);
            m_list_stone = (GList)GetChildComAt(7);
            m_list_get = (GList)GetChildComAt(8);
        }
    }
}