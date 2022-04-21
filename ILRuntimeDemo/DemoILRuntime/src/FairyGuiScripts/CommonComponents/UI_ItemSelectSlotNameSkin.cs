/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ItemSelectSlotNameSkin : GButton
    {
        public Controller m_button;
        public UI_ItemSlotNameSkin m_item;
        public GImage m_selected;
        public const string URL = "ui://0qeyzr63pcju1n";

        public static UI_ItemSelectSlotNameSkin CreateInstance()
        {
            return (UI_ItemSelectSlotNameSkin)UIPackage.CreateComponet("CommonComponents", "ItemSelectSlotNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_item = (UI_ItemSlotNameSkin)GetChildComAt(0);
            m_selected = (GImage)GetChildAt(1);
        }
    }
}