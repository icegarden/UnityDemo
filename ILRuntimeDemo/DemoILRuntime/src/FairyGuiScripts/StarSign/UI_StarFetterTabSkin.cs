/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarFetterTabSkin : GButton
    {
        public Controller m_button;
        public GImage m_n1;
        public GLoader m_icon;
        public GImage m_n3;
        public GImage m_n5;
        public GTextField m_txt_name;
        public GTextField m_txt_count;
        public const string URL = "ui://xplmw3njho4vu";

        public static UI_StarFetterTabSkin CreateInstance()
        {
            return (UI_StarFetterTabSkin)UIPackage.CreateComponet("StarSign", "StarFetterTabSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_txt_name = (GTextField)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
        }
    }
}