/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipSuitItem2Skin : GComponent
    {
        public Controller m_state;
        public GTextField m_txt_name;
        public GTextField m_txt_attr;
        public const string URL = "ui://5ch1xwvwsig294";

        public static UI_EquipSuitItem2Skin CreateInstance()
        {
            return (UI_EquipSuitItem2Skin)UIPackage.CreateComponet("Equip", "EquipSuitItem2Skin");
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