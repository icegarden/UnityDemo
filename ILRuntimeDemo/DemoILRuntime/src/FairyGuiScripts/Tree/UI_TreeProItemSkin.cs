/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeProItemSkin : GComponent
    {
        public GImage m_n33;
        public GComponent m_comp_title;
        public GRichTextField m_txt_addValue;
        public const string URL = "ui://jj5xd8f5mde4n";

        public static UI_TreeProItemSkin CreateInstance()
        {
            return (UI_TreeProItemSkin)UIPackage.CreateComponet("Tree", "TreeProItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n33 = (GImage)GetChildAt(0);
            m_comp_title = (GComponent)GetChildComAt(1);
            m_txt_addValue = (GRichTextField)GetChildAt(2);
        }
    }
}