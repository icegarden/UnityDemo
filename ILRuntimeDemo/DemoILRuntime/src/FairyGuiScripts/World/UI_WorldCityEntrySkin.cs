/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldCityEntrySkin : GButton
    {
        public GLoader m_icon;
        public const string URL = "ui://63ubk2jodibiw";

        public static UI_WorldCityEntrySkin CreateInstance()
        {
            return (UI_WorldCityEntrySkin)UIPackage.CreateComponet("World", "WorldCityEntrySkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}