/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_RoleBloodBarSkin : GProgressBar
    {
        public GImage m_bg;
        public GImage m_tweenbar;
        public GImage m_bar;
        public const string URL = "ui://0qeyzr63ivj53b";

        public static UI_RoleBloodBarSkin CreateInstance()
        {
            return (UI_RoleBloodBarSkin)UIPackage.CreateComponet("CommonComponents", "RoleBloodBarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_tweenbar = (GImage)GetChildAt(1);
            m_bar = (GImage)GetChildAt(2);
        }
    }
}