/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_DecomposeBtnGroup : GComponent
    {
        public GImage m_bg;
        public GButton m_btn_decomposeQuickly;
        public GButton m_btn_decomposeBatch;
        public GButton m_btn_confirm;
        public const string URL = "ui://e98lwrlog1mw4a";

        public static UI_DecomposeBtnGroup CreateInstance()
        {
            return (UI_DecomposeBtnGroup)UIPackage.CreateComponet("Bag", "DecomposeBtnGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_btn_decomposeQuickly = (GButton)GetChildComAt(1);
            m_btn_decomposeBatch = (GButton)GetChildComAt(2);
            m_btn_confirm = (GButton)GetChildComAt(3);
        }
    }
}