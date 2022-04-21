/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipIdentifyMaterialItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public GButton m_btn_select;
        public const string URL = "ui://5ch1xwvwl1me3j";

        public static UI_EquipIdentifyMaterialItemSkin CreateInstance()
        {
            return (UI_EquipIdentifyMaterialItemSkin)UIPackage.CreateComponet("Equip", "EquipIdentifyMaterialItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
            m_btn_select = (GButton)GetChildComAt(4);
        }
    }
}