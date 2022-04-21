/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreePetUpSkin : GComponent
    {
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n9;
        public GImage m_n10;
        public GComponent m_item;
        public GComponent m_item2;
        public GTextField m_txt_msg;
        public GTextField m_txt_lv;
        public GTextField m_txt_lv2;
        public GGroup m_n11;
        public const string URL = "ui://jj5xd8f5mde4t";

        public static UI_TreePetUpSkin CreateInstance()
        {
            return (UI_TreePetUpSkin)UIPackage.CreateComponet("Tree", "TreePetUpSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n9 = (GImage)GetChildAt(2);
            m_n10 = (GImage)GetChildAt(3);
            m_item = (GComponent)GetChildComAt(4);
            m_item2 = (GComponent)GetChildComAt(5);
            m_txt_msg = (GTextField)GetChildAt(6);
            m_txt_lv = (GTextField)GetChildAt(7);
            m_txt_lv2 = (GTextField)GetChildAt(8);
            m_n11 = (GGroup)GetChildAt(9);
        }
    }
}