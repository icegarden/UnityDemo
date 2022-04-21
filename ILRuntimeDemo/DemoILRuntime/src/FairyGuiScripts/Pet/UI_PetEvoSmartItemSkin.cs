/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvoSmartItemSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n6;
        public GImage m_n7;
        public GComponent m_item_origin;
        public GComponent m_item_target;
        public GList m_list_cost;
        public GButton m_btn_select;
        public const string URL = "ui://em095moes3fiak";

        public static UI_PetEvoSmartItemSkin CreateInstance()
        {
            return (UI_PetEvoSmartItemSkin)UIPackage.CreateComponet("Pet", "PetEvoSmartItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n6 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_item_origin = (GComponent)GetChildComAt(3);
            m_item_target = (GComponent)GetChildComAt(4);
            m_list_cost = (GList)GetChildComAt(5);
            m_btn_select = (GButton)GetChildComAt(6);
        }
    }
}