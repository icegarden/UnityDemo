/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_EnegyBar1 : GProgressBar
    {
        public GImage m_n0;
        public GImage m_bar;
        public GImage m_n2;
        public const string URL = "ui://63ubk2jojpuu1z";

        public static UI_EnegyBar1 CreateInstance()
        {
            return (UI_EnegyBar1)UIPackage.CreateComponet("World", "EnegyBar1");
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