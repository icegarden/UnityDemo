/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_ApplyCompSkin : GComponent
    {
        public GButton m_btn_ignoreAll;
        public GButton m_btn_agreeAll;
        public GImage m_n4;
        public GImage m_n7;
        public GTextField m_txt0;
        public GTextField m_txt_count;
        public GList m_list_member;
        public const string URL = "ui://jlg88jbimde4p";

        public static UI_ApplyCompSkin CreateInstance()
        {
            return (UI_ApplyCompSkin)UIPackage.CreateComponet("Friend", "ApplyCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_btn_ignoreAll = (GButton)GetChildComAt(0);
            m_btn_agreeAll = (GButton)GetChildComAt(1);
            m_n4 = (GImage)GetChildAt(2);
            m_n7 = (GImage)GetChildAt(3);
            m_txt0 = (GTextField)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
            m_list_member = (GList)GetChildComAt(6);
        }
    }
}