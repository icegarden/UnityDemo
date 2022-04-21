/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvolutionResultSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n4;
        public GList m_list_item;
        public GButton m_btn_ok;
        public const string URL = "ui://em095moes3fial";

        public static UI_PetEvolutionResultSkin CreateInstance()
        {
            return (UI_PetEvolutionResultSkin)UIPackage.CreateComponet("Pet", "PetEvolutionResultSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_list_item = (GList)GetChildComAt(5);
            m_btn_ok = (GButton)GetChildComAt(6);
        }
    }
}