/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonTab2 : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public GImage m_n1;
        public const string URL = "ui://0qeyzr63d1sk5f";

        public static UI_CommonTab2 CreateInstance()
        {
            return (UI_CommonTab2)UIPackage.CreateComponet("CommonComponents", "CommonTab2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_icon = (GLoader)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
        }
    }
}