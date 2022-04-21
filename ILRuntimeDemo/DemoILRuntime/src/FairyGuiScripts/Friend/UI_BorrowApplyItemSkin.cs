/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BorrowApplyItemSkin : GComponent
    {
        public GImage m_n3;
        public GComponent m_comp_pet;
        public GComponent m_comp_player;
        public GImage m_n8;
        public GImage m_n9;
        public GButton m_btn_ignore;
        public GButton m_btn_agree;
        public GTextField m_txt_power;
        public GTextField m_txt_name;
        public GTextField m_txt0;
        public const string URL = "ui://jlg88jbimr001a";

        public static UI_BorrowApplyItemSkin CreateInstance()
        {
            return (UI_BorrowApplyItemSkin)UIPackage.CreateComponet("Friend", "BorrowApplyItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n3 = (GImage)GetChildAt(0);
            m_comp_pet = (GComponent)GetChildComAt(1);
            m_comp_player = (GComponent)GetChildComAt(2);
            m_n8 = (GImage)GetChildAt(3);
            m_n9 = (GImage)GetChildAt(4);
            m_btn_ignore = (GButton)GetChildComAt(5);
            m_btn_agree = (GButton)GetChildComAt(6);
            m_txt_power = (GTextField)GetChildAt(7);
            m_txt_name = (GTextField)GetChildAt(8);
            m_txt0 = (GTextField)GetChildAt(9);
        }
    }
}