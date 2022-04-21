/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ScrollBar1_grip : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public const string URL = "ui://or7keldwlwv52r";

        public static UI_ScrollBar1_grip CreateInstance()
        {
            return (UI_ScrollBar1_grip)UIPackage.CreateComponet("Chat", "ScrollBar1_grip");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
        }
    }
}