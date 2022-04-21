/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreePetItemSkin : GComponent
    {
        public Controller m_control;
        public GComponent m_item;
        public GImage m_n7;
        public GImage m_n6;
        public GImage m_n5;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_img_maxlvbg;
        public GImage m_img_maxlv;
        public GImage m_n3;
        public GTextField m_txt_cd;
        public const string URL = "ui://jj5xd8f5mde4h";

        public static UI_TreePetItemSkin CreateInstance()
        {
            return (UI_TreePetItemSkin)UIPackage.CreateComponet("Tree", "TreePetItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_n6 = (GImage)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_n1 = (GImage)GetChildAt(4);
            m_n2 = (GImage)GetChildAt(5);
            m_img_maxlvbg = (GImage)GetChildAt(6);
            m_img_maxlv = (GImage)GetChildAt(7);
            m_n3 = (GImage)GetChildAt(8);
            m_txt_cd = (GTextField)GetChildAt(9);
        }
    }
}