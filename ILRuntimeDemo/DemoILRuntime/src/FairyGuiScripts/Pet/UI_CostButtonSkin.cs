/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_CostButtonSkin : GButton
    {
        public GLoader m_icon;
        public GLoader m_cost;
        public GRichTextField m_title;
        public GRichTextField m_count;
        public const string URL = "ui://em095moedd2mbb";

        public static UI_CostButtonSkin CreateInstance()
        {
            return (UI_CostButtonSkin)UIPackage.CreateComponet("Pet", "CostButtonSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
            m_cost = (GLoader)GetChildAt(1);
            m_title = (GRichTextField)GetChildAt(2);
            m_count = (GRichTextField)GetChildAt(3);
        }
    }
}