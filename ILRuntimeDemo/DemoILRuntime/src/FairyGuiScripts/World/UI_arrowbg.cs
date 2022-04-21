/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_arrowbg : GComponent
    {
        public GImage m_arrow;
        public const string URL = "ui://63ubk2jomlxa1a";

        public static UI_arrowbg CreateInstance()
        {
            return (UI_arrowbg)UIPackage.CreateComponet("World", "arrowbg");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_arrow = (GImage)GetChildAt(0);
        }
    }
}