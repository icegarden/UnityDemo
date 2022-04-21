/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetExchangeItemSkin : GComponent
    {
        public GImage m_n0;
        public GList m_list_cost;
        public GTextField m_n2;
        public GComponent m_item_target;
        public GButton m_btn_exchange;
        public const string URL = "ui://em095moert0bb";

        public static UI_PetExchangeItemSkin CreateInstance()
        {
            return (UI_PetExchangeItemSkin)UIPackage.CreateComponet("Pet", "PetExchangeItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_list_cost = (GList)GetChildComAt(1);
            m_n2 = (GTextField)GetChildAt(2);
            m_item_target = (GComponent)GetChildComAt(3);
            m_btn_exchange = (GButton)GetChildComAt(4);
        }
    }
}