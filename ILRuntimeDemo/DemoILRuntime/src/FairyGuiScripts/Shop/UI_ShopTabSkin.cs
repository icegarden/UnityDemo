/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_ShopTabSkin : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n1;
        public GTextField m_title;
        public GTextField m_txt_time;
        public const string URL = "ui://v22o2wamg7dee";

        public static UI_ShopTabSkin CreateInstance()
        {
            return (UI_ShopTabSkin)UIPackage.CreateComponet("Shop", "ShopTabSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
            m_txt_time = (GTextField)GetChildAt(3);
        }
    }
}