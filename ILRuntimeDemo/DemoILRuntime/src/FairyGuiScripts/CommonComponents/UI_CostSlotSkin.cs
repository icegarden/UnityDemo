/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CostSlotSkin : GComponent
    {
        public UI_ItemSlotSkin m_item;
        public GRichTextField m_txt_count;
        public const string URL = "ui://0qeyzr63pcju10";

        public static UI_CostSlotSkin CreateInstance()
        {
            return (UI_CostSlotSkin)UIPackage.CreateComponet("CommonComponents", "CostSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (UI_ItemSlotSkin)GetChildComAt(0);
            m_txt_count = (GRichTextField)GetChildAt(1);
        }
    }
}