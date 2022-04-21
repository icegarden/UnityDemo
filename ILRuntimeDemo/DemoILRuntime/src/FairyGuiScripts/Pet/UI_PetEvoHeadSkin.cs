/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvoHeadSkin : GComponent
    {
        public Controller m_state;
        public GComponent m_head;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n4;
        public GImage m_n9;
        public GImage m_n5;
        public GImage m_n7;
        public GImage m_n12;
        public GTextField m_txt_recommend;
        public GTextField m_txt_cost;
        public const string URL = "ui://em095moes3fiac";

        public static UI_PetEvoHeadSkin CreateInstance()
        {
            return (UI_PetEvoHeadSkin)UIPackage.CreateComponet("Pet", "PetEvoHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_head = (GComponent)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_n9 = (GImage)GetChildAt(5);
            m_n5 = (GImage)GetChildAt(6);
            m_n7 = (GImage)GetChildAt(7);
            m_n12 = (GImage)GetChildAt(8);
            m_txt_recommend = (GTextField)GetChildAt(9);
            m_txt_cost = (GTextField)GetChildAt(10);
        }
    }
}