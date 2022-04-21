/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipSelectSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GImage m_n7;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GTextField m_txt_score;
        public GTextField m_txt_tip;
        public GList m_list_equip;
        public const string URL = "ui://5ch1xwvwsig28w";

        public static UI_EquipSelectSkin CreateInstance()
        {
            return (UI_EquipSelectSkin)UIPackage.CreateComponet("Equip", "EquipSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_item = (GComponent)GetChildComAt(3);
            m_txt_name = (GRichTextField)GetChildAt(4);
            m_txt_score = (GTextField)GetChildAt(5);
            m_txt_tip = (GTextField)GetChildAt(6);
            m_list_equip = (GList)GetChildComAt(7);
        }
    }
}