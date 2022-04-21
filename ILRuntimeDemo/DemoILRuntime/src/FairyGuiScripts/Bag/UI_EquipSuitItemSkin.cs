/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_EquipSuitItemSkin : GComponent
    {
        public Controller m_state;
        public GTextField m_txt_name;
        public GTextField m_txt_attr;
        public const string URL = "ui://e98lwrlorb882n";

        public static UI_EquipSuitItemSkin CreateInstance()
        {
            return (UI_EquipSuitItemSkin)UIPackage.CreateComponet("Bag", "EquipSuitItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_txt_name = (GTextField)GetChildAt(0);
            m_txt_attr = (GTextField)GetChildAt(1);
        }
    }
}