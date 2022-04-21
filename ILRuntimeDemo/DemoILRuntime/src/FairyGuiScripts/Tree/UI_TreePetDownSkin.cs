/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreePetDownSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GImage m_n8;
        public GComponent m_item;
        public GComponent m_item2;
        public GTextField m_txt_lv;
        public GTextField m_txt_lv2;
        public GTextField m_txt0;
        public GRichTextField m_txt_msg;
        public GGroup m_n7;
        public const string URL = "ui://jj5xd8f5mde4v";

        public static UI_TreePetDownSkin CreateInstance()
        {
            return (UI_TreePetDownSkin)UIPackage.CreateComponet("Tree", "TreePetDownSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_btn_confirm = (GButton)GetChildComAt(2);
            m_btn_cancel = (GButton)GetChildComAt(3);
            m_n8 = (GImage)GetChildAt(4);
            m_item = (GComponent)GetChildComAt(5);
            m_item2 = (GComponent)GetChildComAt(6);
            m_txt_lv = (GTextField)GetChildAt(7);
            m_txt_lv2 = (GTextField)GetChildAt(8);
            m_txt0 = (GTextField)GetChildAt(9);
            m_txt_msg = (GRichTextField)GetChildAt(10);
            m_n7 = (GGroup)GetChildAt(11);
        }
    }
}