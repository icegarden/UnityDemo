/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipIdentifySelectSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_equip;
        public GButton m_btn_confirm;
        public const string URL = "ui://5ch1xwvwsig20";

        public static UI_EquipIdentifySelectSkin CreateInstance()
        {
            return (UI_EquipIdentifySelectSkin)UIPackage.CreateComponet("Equip", "EquipIdentifySelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_equip = (GList)GetChildComAt(1);
            m_btn_confirm = (GButton)GetChildComAt(2);
        }
    }
}