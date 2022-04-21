/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_StoneCombineTipsSkin : GComponent
    {
        public GImage m_n1;
        public GGraph m_n7;
        public GTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://em095moeq5d45i";

        public static UI_StoneCombineTipsSkin CreateInstance()
        {
            return (UI_StoneCombineTipsSkin)UIPackage.CreateComponet("Pet", "StoneCombineTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n7 = (GGraph)GetChildAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
        }
    }
}