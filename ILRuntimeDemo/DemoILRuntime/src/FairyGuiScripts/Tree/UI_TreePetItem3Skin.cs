/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreePetItem3Skin : GComponent
    {
        public GComponent m_item;
        public GImage m_img_none;
        public GImage m_n8;
        public GLoader m_img_icon;
        public GTextField m_txt_count;
        public const string URL = "ui://jj5xd8f5mde41e";

        public static UI_TreePetItem3Skin CreateInstance()
        {
            return (UI_TreePetItem3Skin)UIPackage.CreateComponet("Tree", "TreePetItem3Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (GComponent)GetChildComAt(0);
            m_img_none = (GImage)GetChildAt(1);
            m_n8 = (GImage)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_txt_count = (GTextField)GetChildAt(4);
        }
    }
}