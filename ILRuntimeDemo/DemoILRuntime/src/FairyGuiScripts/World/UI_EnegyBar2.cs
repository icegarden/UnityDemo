/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_EnegyBar2 : GProgressBar
    {
        public GImage m_n0;
        public GImage m_bar;
        public GImage m_n2;
        public const string URL = "ui://63ubk2jojpuu3z";

        public static UI_EnegyBar2 CreateInstance()
        {
            return (UI_EnegyBar2)UIPackage.CreateComponet("World", "EnegyBar2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_bar = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
        }
    }
}