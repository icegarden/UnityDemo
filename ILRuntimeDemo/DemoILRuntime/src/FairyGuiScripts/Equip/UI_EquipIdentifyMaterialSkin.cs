/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipIdentifyMaterialSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public GRichTextField m_txt_count;
        public GButton m_btn_notAdd;
        public const string URL = "ui://5ch1xwvwl1me3h";

        public static UI_EquipIdentifyMaterialSkin CreateInstance()
        {
            return (UI_EquipIdentifyMaterialSkin)UIPackage.CreateComponet("Equip", "EquipIdentifyMaterialSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
            m_btn_notAdd = (GButton)GetChildComAt(3);
        }
    }
}