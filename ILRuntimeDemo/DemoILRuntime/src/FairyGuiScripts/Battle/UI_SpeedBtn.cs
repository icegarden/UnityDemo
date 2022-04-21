/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_SpeedBtn : GButton
    {
        public GLoader m_icon;
        public GTextField m_title;
        public const string URL = "ui://ej3y9mmygl373w";

        public static UI_SpeedBtn CreateInstance()
        {
            return (UI_SpeedBtn)UIPackage.CreateComponet("Battle", "SpeedBtn");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
        }
    }
}