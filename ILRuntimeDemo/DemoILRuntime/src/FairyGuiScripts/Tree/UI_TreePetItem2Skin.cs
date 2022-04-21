/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreePetItem2Skin : GButton
    {
        public Controller m_button;
        public GComponent m_item;
        public GImage m_n8;
        public GImage m_n9;
        public const string URL = "ui://jj5xd8f5mde41d";

        public static UI_TreePetItem2Skin CreateInstance()
        {
            return (UI_TreePetItem2Skin)UIPackage.CreateComponet("Tree", "TreePetItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_n8 = (GImage)GetChildAt(1);
            m_n9 = (GImage)GetChildAt(2);
        }
    }
}