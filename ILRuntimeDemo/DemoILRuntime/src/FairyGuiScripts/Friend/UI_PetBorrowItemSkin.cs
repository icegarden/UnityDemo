/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_PetBorrowItemSkin : GComponent
    {
        public UI_empty m_avtCon;
        public GImage m_n39;
        public GButton m_btn_back;
        public GTextField m_txt_name;
        public const string URL = "ui://jlg88jbimr0011";

        public static UI_PetBorrowItemSkin CreateInstance()
        {
            return (UI_PetBorrowItemSkin)UIPackage.CreateComponet("Friend", "PetBorrowItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_avtCon = (UI_empty)GetChildComAt(0);
            m_n39 = (GImage)GetChildAt(1);
            m_btn_back = (GButton)GetChildComAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
        }
    }
}