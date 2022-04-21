/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetUpgradeTipsSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n36;
        public GImage m_n37;
        public GTextField m_txt_curLevel;
        public GTextField m_txt_nextLevel;
        public GComponent m_item_head;
        public GList m_list_cost;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public const string URL = "ui://em095moeh46caz";

        public static UI_PetUpgradeTipsSkin CreateInstance()
        {
            return (UI_PetUpgradeTipsSkin)UIPackage.CreateComponet("Pet", "PetUpgradeTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n36 = (GImage)GetChildAt(1);
            m_n37 = (GImage)GetChildAt(2);
            m_txt_curLevel = (GTextField)GetChildAt(3);
            m_txt_nextLevel = (GTextField)GetChildAt(4);
            m_item_head = (GComponent)GetChildComAt(5);
            m_list_cost = (GList)GetChildComAt(6);
            m_btn_confirm = (GButton)GetChildComAt(7);
            m_btn_cancel = (GButton)GetChildComAt(8);
        }
    }
}