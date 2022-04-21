/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrUpgradeItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public GImage m_img_arrow;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_curValue;
        public GRichTextField m_txt_nextValue;
        public const string URL = "ui://0qeyzr63xxxi4k";

        public static UI_AttrUpgradeItemSkin CreateInstance()
        {
            return (UI_AttrUpgradeItemSkin)UIPackage.CreateComponet("CommonComponents", "AttrUpgradeItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_img_arrow = (GImage)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_curValue = (GRichTextField)GetChildAt(3);
            m_txt_nextValue = (GRichTextField)GetChildAt(4);
        }
    }
}