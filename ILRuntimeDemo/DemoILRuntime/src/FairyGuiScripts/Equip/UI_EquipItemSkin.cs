/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GTextField m_txt_score;
        public GButton m_btn_equip;
        public GButton m_btn_replace;
        public GComponent m_head_equiped;
        public const string URL = "ui://5ch1xwvwh7469a";

        public static UI_EquipItemSkin CreateInstance()
        {
            return (UI_EquipItemSkin)UIPackage.CreateComponet("Equip", "EquipItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_item = (GComponent)GetChildComAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_score = (GTextField)GetChildAt(3);
            m_btn_equip = (GButton)GetChildComAt(4);
            m_btn_replace = (GButton)GetChildComAt(5);
            m_head_equiped = (GComponent)GetChildComAt(6);
        }
    }
}