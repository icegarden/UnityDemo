/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetUpgradeOpSkin : GComponent
    {
        public GList m_list_cost;
        public GTextField m_txt_tip;
        public GButton m_btn_onekey;
        public GButton m_btn_upgrade;
        public GButton m_btn_gotoEvo;
        public GButton m_btn_gotoTree;
        public const string URL = "ui://em095moeh46cat";

        public static UI_PetUpgradeOpSkin CreateInstance()
        {
            return (UI_PetUpgradeOpSkin)UIPackage.CreateComponet("Pet", "PetUpgradeOpSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_list_cost = (GList)GetChildComAt(0);
            m_txt_tip = (GTextField)GetChildAt(1);
            m_btn_onekey = (GButton)GetChildComAt(2);
            m_btn_upgrade = (GButton)GetChildComAt(3);
            m_btn_gotoEvo = (GButton)GetChildComAt(4);
            m_btn_gotoTree = (GButton)GetChildComAt(5);
        }
    }
}