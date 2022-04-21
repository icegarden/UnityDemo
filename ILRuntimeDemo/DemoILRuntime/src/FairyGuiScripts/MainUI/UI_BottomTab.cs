/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainUI
{
    public partial class UI_BottomTab : GButton
    {
        public Controller m_button;
        public GLoader m_icon;
        public const string URL = "ui://eb1q6ro1pcjuc";

        public static UI_BottomTab CreateInstance()
        {
            return (UI_BottomTab)UIPackage.CreateComponet("MainUI", "BottomTab");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_icon = (GLoader)GetChildAt(0);
        }
    }
}