/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_SelectEquipTipsSkin : GComponent
    {
        public Controller m_state;
        public UI_SelectEquipInfoSkin m_item_equiped;
        public UI_SelectEquipInfoSkin m_item_replace;
        public const string URL = "ui://5ch1xwvwsig28y";

        public static UI_SelectEquipTipsSkin CreateInstance()
        {
            return (UI_SelectEquipTipsSkin)UIPackage.CreateComponet("Equip", "SelectEquipTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_item_equiped = (UI_SelectEquipInfoSkin)GetChildComAt(0);
            m_item_replace = (UI_SelectEquipInfoSkin)GetChildComAt(1);
        }
    }
}