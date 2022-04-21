/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldCityTabSkin : GButton
    {
        public Controller m_button;
        public Controller m_state;
        public GImage m_n4;
        public GLoader m_icon;
        public GImage m_n3;
        public GImage m_n5;
        public GImage m_n7;
        public GImage m_n8;
        public GTextField m_title;
        public const string URL = "ui://63ubk2jodibic";

        public static UI_WorldCityTabSkin CreateInstance()
        {
            return (UI_WorldCityTabSkin)UIPackage.CreateComponet("World", "WorldCityTabSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_n4 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_n7 = (GImage)GetChildAt(4);
            m_n8 = (GImage)GetChildAt(5);
            m_title = (GTextField)GetChildAt(6);
        }
    }
}