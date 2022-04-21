/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_AddFriendCompSkin : GComponent
    {
        public GImage m_n19;
        public GImage m_n21;
        public GImage m_n13;
        public GButton m_btn_refresh;
        public GButton m_btn_search;
        public GImage m_n14;
        public GImage m_n23;
        public GImage m_n26;
        public GTextField m_txt1;
        public GTextField m_txt0;
        public GTextField m_txt_count;
        public GTextInput m_txt_name;
        public GList m_list_member;
        public const string URL = "ui://jlg88jbimde4q";

        public static UI_AddFriendCompSkin CreateInstance()
        {
            return (UI_AddFriendCompSkin)UIPackage.CreateComponet("Friend", "AddFriendCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n19 = (GImage)GetChildAt(0);
            m_n21 = (GImage)GetChildAt(1);
            m_n13 = (GImage)GetChildAt(2);
            m_btn_refresh = (GButton)GetChildComAt(3);
            m_btn_search = (GButton)GetChildComAt(4);
            m_n14 = (GImage)GetChildAt(5);
            m_n23 = (GImage)GetChildAt(6);
            m_n26 = (GImage)GetChildAt(7);
            m_txt1 = (GTextField)GetChildAt(8);
            m_txt0 = (GTextField)GetChildAt(9);
            m_txt_count = (GTextField)GetChildAt(10);
            m_txt_name = (GTextInput)GetChildAt(11);
            m_list_member = (GList)GetChildComAt(12);
        }
    }
}