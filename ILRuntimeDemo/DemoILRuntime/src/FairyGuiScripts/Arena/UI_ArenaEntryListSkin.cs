/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaEntryListSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GLoader m_img_bottom;
        public GLabel m_title;
        public GList m_list_item;
        public GButton m_btn_local;
        public GButton m_btn_back;
        public GButton m_btn_cross;
        public const string URL = "ui://m8qegzmncnj30";

        public static UI_ArenaEntryListSkin CreateInstance()
        {
            return (UI_ArenaEntryListSkin)UIPackage.CreateComponet("Arena", "ArenaEntryListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_btn_local = (GButton)GetChildComAt(4);
            m_btn_back = (GButton)GetChildComAt(5);
            m_btn_cross = (GButton)GetChildComAt(6);
        }
    }
}