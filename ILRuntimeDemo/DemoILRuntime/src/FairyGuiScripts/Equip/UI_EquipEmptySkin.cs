/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipEmptySkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public const string URL = "ui://5ch1xwvwsig28u";

        public static UI_EquipEmptySkin CreateInstance()
        {
            return (UI_EquipEmptySkin)UIPackage.CreateComponet("Equip", "EquipEmptySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
        }
    }
}