/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetUpgradeAttrItem2Skin : GComponent
    {
        public GImage m_n5;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_curValue;
        public GRichTextField m_txt_nextValue;
        public const string URL = "ui://em095moexxxi57";

        public static UI_PetUpgradeAttrItem2Skin CreateInstance()
        {
            return (UI_PetUpgradeAttrItem2Skin)UIPackage.CreateComponet("Pet", "PetUpgradeAttrItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n5 = (GImage)GetChildAt(0);
            m_txt_name = (GRichTextField)GetChildAt(1);
            m_txt_curValue = (GRichTextField)GetChildAt(2);
            m_txt_nextValue = (GRichTextField)GetChildAt(3);
        }
    }
}