/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetProduceSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_bg;
        public GImage m_n10;
        public GList m_list_egg;
        public GList m_list_exchange;
        public GButton m_btn_produceQuckly;
        public GButton m_btn_produce;
        public GButton m_btn_exchange;
        public GButton m_btn_welfare;
        public GButton m_btn_back;
        public const string URL = "ui://em095moert0b9";

        public static UI_PetProduceSkin CreateInstance()
        {
            return (UI_PetProduceSkin)UIPackage.CreateComponet("Pet", "PetProduceSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_n10 = (GImage)GetChildAt(1);
            m_list_egg = (GList)GetChildComAt(2);
            m_list_exchange = (GList)GetChildComAt(3);
            m_btn_produceQuckly = (GButton)GetChildComAt(4);
            m_btn_produce = (GButton)GetChildComAt(5);
            m_btn_exchange = (GButton)GetChildComAt(6);
            m_btn_welfare = (GButton)GetChildComAt(7);
            m_btn_back = (GButton)GetChildComAt(8);
        }
    }
}