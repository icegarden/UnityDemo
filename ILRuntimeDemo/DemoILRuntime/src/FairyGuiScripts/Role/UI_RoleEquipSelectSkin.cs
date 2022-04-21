/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleEquipSelectSkin : GComponent
    {
        public Controller m_state;
        public GComponent m_n0;
        public GImage m_n22;
        public GImage m_n20;
        public GTextField m_tip;
        public GComboBox m_btn_filter;
        public UI_RoleEquipTipsSkin m_tip_equiped;
        public UI_RoleEquipTipsSkin m_tip_replace;
        public GList m_list_equip;
        public GList m_list_get;
        public const string URL = "ui://edfpwlj6sc3q1e";

        public static UI_RoleEquipSelectSkin CreateInstance()
        {
            return (UI_RoleEquipSelectSkin)UIPackage.CreateComponet("Role", "RoleEquipSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n0 = (GComponent)GetChildComAt(0);
            m_n22 = (GImage)GetChildAt(1);
            m_n20 = (GImage)GetChildAt(2);
            m_tip = (GTextField)GetChildAt(3);
            m_btn_filter = (GComboBox)GetChildComAt(4);
            m_tip_equiped = (UI_RoleEquipTipsSkin)GetChildComAt(5);
            m_tip_replace = (UI_RoleEquipTipsSkin)GetChildComAt(6);
            m_list_equip = (GList)GetChildComAt(7);
            m_list_get = (GList)GetChildComAt(8);
        }
    }
}