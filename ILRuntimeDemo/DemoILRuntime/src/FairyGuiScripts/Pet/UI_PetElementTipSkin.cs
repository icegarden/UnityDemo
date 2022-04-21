/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetElementTipSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n4;
        public GImage m_n5;
        public GTextField m_txt_element;
        public GTextField m_txt_title;
        public GImage m_n6;
        public GImage m_n7;
        public GImage m_n8;
        public GImage m_n9;
        public GImage m_n10;
        public GImage m_n11;
        public GImage m_n12;
        public GImage m_n13;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n16;
        public GImage m_n17;
        public const string URL = "ui://em095moes3fia6";

        public static UI_PetElementTipSkin CreateInstance()
        {
            return (UI_PetElementTipSkin)UIPackage.CreateComponet("Pet", "PetElementTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_txt_element = (GTextField)GetChildAt(3);
            m_txt_title = (GTextField)GetChildAt(4);
            m_n6 = (GImage)GetChildAt(5);
            m_n7 = (GImage)GetChildAt(6);
            m_n8 = (GImage)GetChildAt(7);
            m_n9 = (GImage)GetChildAt(8);
            m_n10 = (GImage)GetChildAt(9);
            m_n11 = (GImage)GetChildAt(10);
            m_n12 = (GImage)GetChildAt(11);
            m_n13 = (GImage)GetChildAt(12);
            m_n14 = (GImage)GetChildAt(13);
            m_n15 = (GImage)GetChildAt(14);
            m_n16 = (GImage)GetChildAt(15);
            m_n17 = (GImage)GetChildAt(16);
        }
    }
}