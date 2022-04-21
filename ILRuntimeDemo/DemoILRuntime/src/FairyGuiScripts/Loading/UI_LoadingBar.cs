/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Loading
{
    public partial class UI_LoadingBar : GProgressBar
    {
        public GImage m_n3;
        public GImage m_bar;
        public const string URL = "ui://x0wur3dic6ya0";

        public static UI_LoadingBar CreateInstance()
        {
            return (UI_LoadingBar)UIPackage.CreateComponet("Loading", "LoadingBar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n3 = (GImage)GetChildAt(0);
            m_bar = (GImage)GetChildAt(1);
        }
    }
}