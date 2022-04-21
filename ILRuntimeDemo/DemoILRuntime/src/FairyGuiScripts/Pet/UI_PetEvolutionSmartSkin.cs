/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvolutionSmartSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n2;
        public GTextField m_txt_tip;
        public GList m_list_item;
        public GButton m_btn_ok;
        public const string URL = "ui://em095moes3fiaj";

        public static UI_PetEvolutionSmartSkin CreateInstance()
        {
            return (UI_PetEvolutionSmartSkin)UIPackage.CreateComponet("Pet", "PetEvolutionSmartSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_btn_ok = (GButton)GetChildComAt(4);
        }
    }
}