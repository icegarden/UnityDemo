/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_OpenStoneSlotSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n7;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GList m_list_cost;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public const string URL = "ui://em095moert0bu";

        public static UI_OpenStoneSlotSkin CreateInstance()
        {
            return (UI_OpenStoneSlotSkin)UIPackage.CreateComponet("Pet", "OpenStoneSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_txt_tip1 = (GTextField)GetChildAt(2);
            m_txt_tip2 = (GTextField)GetChildAt(3);
            m_list_cost = (GList)GetChildComAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_cancel = (GButton)GetChildComAt(6);
        }
    }
}