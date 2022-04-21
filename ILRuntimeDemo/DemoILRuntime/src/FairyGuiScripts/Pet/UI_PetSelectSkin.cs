/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetSelectSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GImage m_n13;
        public GImage m_n15;
        public GTextField m_txt_none;
        public GTextField m_txt_count;
        public GTextField m_txt_tip;
        public GList m_list_item;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public const string URL = "ui://em095moert0br";

        public static UI_PetSelectSkin CreateInstance()
        {
            return (UI_PetSelectSkin)UIPackage.CreateComponet("Pet", "PetSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n13 = (GImage)GetChildAt(1);
            m_n15 = (GImage)GetChildAt(2);
            m_txt_none = (GTextField)GetChildAt(3);
            m_txt_count = (GTextField)GetChildAt(4);
            m_txt_tip = (GTextField)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
            m_btn_confirm = (GButton)GetChildComAt(7);
            m_btn_cancel = (GButton)GetChildComAt(8);
        }
    }
}