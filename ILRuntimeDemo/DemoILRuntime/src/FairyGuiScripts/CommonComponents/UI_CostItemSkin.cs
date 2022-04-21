/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CostItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public GRichTextField m_txt_count;
        public const string URL = "ui://0qeyzr63rt0bl";

        public static UI_CostItemSkin CreateInstance()
        {
            return (UI_CostItemSkin)UIPackage.CreateComponet("CommonComponents", "CostItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_count = (GRichTextField)GetChildAt(1);
        }
    }
}