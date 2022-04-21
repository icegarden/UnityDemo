/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CostSlot3Skin : GComponent
    {
        public UI_ItemSlotSkin m_item;
        public GRichTextField m_txt_count;
        public GTextField m_n1;
        public const string URL = "ui://0qeyzr63rt0bc";

        public static UI_CostSlot3Skin CreateInstance()
        {
            return (UI_CostSlot3Skin)UIPackage.CreateComponet("CommonComponents", "CostSlot3Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (UI_ItemSlotSkin)GetChildComAt(0);
            m_txt_count = (GRichTextField)GetChildAt(1);
            m_n1 = (GTextField)GetChildAt(2);
        }
    }
}