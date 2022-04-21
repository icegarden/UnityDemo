/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeGrowSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GComponent m_item_get;
        public GTextField m_txt0;
        public GList m_list_pet;
        public GButton m_btn_confirm;
        public GGroup m_n7;
        public const string URL = "ui://jj5xd8f5mde419";

        public static UI_TreeGrowSkin CreateInstance()
        {
            return (UI_TreeGrowSkin)UIPackage.CreateComponet("Tree", "TreeGrowSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_item_get = (GComponent)GetChildComAt(2);
            m_txt0 = (GTextField)GetChildAt(3);
            m_list_pet = (GList)GetChildComAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_n7 = (GGroup)GetChildAt(6);
        }
    }
}