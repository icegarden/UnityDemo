/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BorrowSelectPetItemSkin : GComponent
    {
        public GComponent m_item;
        public GImage m_img_select0;
        public GImage m_img_select1;
        public GLoader m_img_num;
        public const string URL = "ui://jlg88jbimr001f";

        public static UI_BorrowSelectPetItemSkin CreateInstance()
        {
            return (UI_BorrowSelectPetItemSkin)UIPackage.CreateComponet("Friend", "BorrowSelectPetItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (GComponent)GetChildComAt(0);
            m_img_select0 = (GImage)GetChildAt(1);
            m_img_select1 = (GImage)GetChildAt(2);
            m_img_num = (GLoader)GetChildAt(3);
        }
    }
}