/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_DecomposeBatchSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n8;
        public GTextField m_txt_tip;
        public GButton m_btn_white;
        public GButton m_btn_blue;
        public GButton m_btn_purple;
        public const string URL = "ui://e98lwrlopcju1l";

        public static UI_DecomposeBatchSkin CreateInstance()
        {
            return (UI_DecomposeBatchSkin)UIPackage.CreateComponet("Bag", "DecomposeBatchSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n8 = (GImage)GetChildAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
            m_btn_white = (GButton)GetChildComAt(3);
            m_btn_blue = (GButton)GetChildComAt(4);
            m_btn_purple = (GButton)GetChildComAt(5);
        }
    }
}