/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ItemSelectSlotSkin : GButton
    {
        public Controller m_button;
        public UI_ItemSlotSkin m_item;
        public GImage m_selected;
        public const string URL = "ui://0qeyzr63pcju1m";

        public static UI_ItemSelectSlotSkin CreateInstance()
        {
            return (UI_ItemSelectSlotSkin)UIPackage.CreateComponet("CommonComponents", "ItemSelectSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_item = (UI_ItemSlotSkin)GetChildComAt(0);
            m_selected = (GImage)GetChildAt(1);
        }
    }
}