/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RefineAttrItemSkin : GComponent
    {
        public GImage m_n4;
        public GRichTextField m_txt_attr;
        public GButton m_btn_lock;
        public const string URL = "ui://edfpwlj6oii81n";

        public static UI_RefineAttrItemSkin CreateInstance()
        {
            return (UI_RefineAttrItemSkin)UIPackage.CreateComponet("Role", "RefineAttrItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_txt_attr = (GRichTextField)GetChildAt(1);
            m_btn_lock = (GButton)GetChildComAt(2);
        }
    }
}