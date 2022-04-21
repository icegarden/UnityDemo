/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ItemSlotNameSkin : GComponent
    {
        public UI_ItemSlotSkin m_item;
        public GRichTextField m_txt_name;
        public const string URL = "ui://0qeyzr63pcju1h";

        public static UI_ItemSlotNameSkin CreateInstance()
        {
            return (UI_ItemSlotNameSkin)UIPackage.CreateComponet("CommonComponents", "ItemSlotNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (UI_ItemSlotSkin)GetChildComAt(0);
            m_txt_name = (GRichTextField)GetChildAt(1);
        }
    }
}