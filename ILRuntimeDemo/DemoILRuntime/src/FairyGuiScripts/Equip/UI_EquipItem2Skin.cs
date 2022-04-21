/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipItem2Skin : GComponent
    {
        public GComponent m_item;
        public GButton m_btn_sub;
        public GTextField m_txt_count;
        public const string URL = "ui://5ch1xwvwh7469c";

        public static UI_EquipItem2Skin CreateInstance()
        {
            return (UI_EquipItem2Skin)UIPackage.CreateComponet("Equip", "EquipItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (GComponent)GetChildComAt(0);
            m_btn_sub = (GButton)GetChildComAt(1);
            m_txt_count = (GTextField)GetChildAt(2);
        }
    }
}