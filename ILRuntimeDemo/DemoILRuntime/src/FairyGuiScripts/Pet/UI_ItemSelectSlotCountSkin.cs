/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_ItemSelectSlotCountSkin : GButton
    {
        public Controller m_button;
        public GComponent m_item;
        public GImage m_selected;
        public GTextField m_txt_count;
        public const string URL = "ui://em095moerb881h";

        public static UI_ItemSelectSlotCountSkin CreateInstance()
        {
            return (UI_ItemSelectSlotCountSkin)UIPackage.CreateComponet("Pet", "ItemSelectSlotCountSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_selected = (GImage)GetChildAt(1);
            m_txt_count = (GTextField)GetChildAt(2);
        }
    }
}