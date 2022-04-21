/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetDecomposeBatchSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n7;
        public GTextField m_txt_desc;
        public GButton m_btn_white;
        public GButton m_btn_blue;
        public GButton m_btn_purple;
        public const string URL = "ui://em095moert0b5";

        public static UI_PetDecomposeBatchSkin CreateInstance()
        {
            return (UI_PetDecomposeBatchSkin)UIPackage.CreateComponet("Pet", "PetDecomposeBatchSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_txt_desc = (GTextField)GetChildAt(2);
            m_btn_white = (GButton)GetChildComAt(3);
            m_btn_blue = (GButton)GetChildComAt(4);
            m_btn_purple = (GButton)GetChildComAt(5);
        }
    }
}