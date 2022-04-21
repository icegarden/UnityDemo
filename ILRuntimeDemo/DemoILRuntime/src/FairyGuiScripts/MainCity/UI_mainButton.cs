/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCity
{
    public partial class UI_mainButton : GButton
    {
        public Controller m_button;
        public Controller m_lock;
        public GImage m_n4;
        public GImage m_n5;
        public GTextField m_title;
        public const string URL = "ui://ewnupz9mhiooh";

        public static UI_mainButton CreateInstance()
        {
            return (UI_mainButton)UIPackage.CreateComponet("MainCity", "mainButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_lock = GetControllerAt(1);
            m_n4 = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_title = (GTextField)GetChildAt(2);
        }
    }
}