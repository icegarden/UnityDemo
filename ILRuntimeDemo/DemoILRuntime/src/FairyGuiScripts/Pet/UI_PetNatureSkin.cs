/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetNatureSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GImage m_n16;
        public GImage m_bg_tmp;
        public GImage m_n12;
        public GImage m_bg_tmpEmpty;
        public GRichTextField m_txt_curName;
        public GRichTextField m_txt_tmpName;
        public GList m_list_curAttr;
        public GList m_list_tmpAttr;
        public GComponent m_item_cost;
        public GButton m_btn_test;
        public GButton m_btn_replace;
        public const string URL = "ui://em095moert0bl";

        public static UI_PetNatureSkin CreateInstance()
        {
            return (UI_PetNatureSkin)UIPackage.CreateComponet("Pet", "PetNatureSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n16 = (GImage)GetChildAt(1);
            m_bg_tmp = (GImage)GetChildAt(2);
            m_n12 = (GImage)GetChildAt(3);
            m_bg_tmpEmpty = (GImage)GetChildAt(4);
            m_txt_curName = (GRichTextField)GetChildAt(5);
            m_txt_tmpName = (GRichTextField)GetChildAt(6);
            m_list_curAttr = (GList)GetChildComAt(7);
            m_list_tmpAttr = (GList)GetChildComAt(8);
            m_item_cost = (GComponent)GetChildComAt(9);
            m_btn_test = (GButton)GetChildComAt(10);
            m_btn_replace = (GButton)GetChildComAt(11);
        }
    }
}