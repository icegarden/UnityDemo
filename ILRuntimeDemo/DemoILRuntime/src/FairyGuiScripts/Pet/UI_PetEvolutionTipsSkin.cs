/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvolutionTipsSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GRichTextField m_txt_tip1;
        public GRichTextField m_txt_petName;
        public GRichTextField m_txt_tip2;
        public GList m_list_pet;
        public GList m_list_tip;
        public const string URL = "ui://em095moes3fiam";

        public static UI_PetEvolutionTipsSkin CreateInstance()
        {
            return (UI_PetEvolutionTipsSkin)UIPackage.CreateComponet("Pet", "PetEvolutionTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_btn_confirm = (GButton)GetChildComAt(1);
            m_btn_cancel = (GButton)GetChildComAt(2);
            m_txt_tip1 = (GRichTextField)GetChildAt(3);
            m_txt_petName = (GRichTextField)GetChildAt(4);
            m_txt_tip2 = (GRichTextField)GetChildAt(5);
            m_list_pet = (GList)GetChildComAt(6);
            m_list_tip = (GList)GetChildComAt(7);
        }
    }
}