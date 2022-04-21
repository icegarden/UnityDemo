/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Library
{
    public partial class UI_LibrarySkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GButton m_btn_research;
        public GButton m_btn_back;
        public GButton m_btn_book;
        public GList m_list_item;
        public GLabel m_title;
        public const string URL = "ui://vkxqgoc5ycl74";

        public static UI_LibrarySkin CreateInstance()
        {
            return (UI_LibrarySkin)UIPackage.CreateComponet("Library", "LibrarySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_btn_research = (GButton)GetChildComAt(1);
            m_btn_back = (GButton)GetChildComAt(2);
            m_btn_book = (GButton)GetChildComAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_title = (GLabel)GetChildComAt(5);
        }
    }
}