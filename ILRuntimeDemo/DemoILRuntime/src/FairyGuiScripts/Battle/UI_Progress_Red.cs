/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_Progress_Red : GProgressBar
    {
        public GImage m_n4;
        public GLoader m_downbar;
        public GLoader m_slowBar;
        public GLoader m_upbar;
        public GImage m_bar;
        public GImage m_bg;
        public GTextField m_titile;
        public const string URL = "ui://ej3y9mmyivj53d";

        public static UI_Progress_Red CreateInstance()
        {
            return (UI_Progress_Red)UIPackage.CreateComponet("Battle", "Progress_Red");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_downbar = (GLoader)GetChildAt(1);
            m_slowBar = (GLoader)GetChildAt(2);
            m_upbar = (GLoader)GetChildAt(3);
            m_bar = (GImage)GetChildAt(4);
            m_bg = (GImage)GetChildAt(5);
            m_titile = (GTextField)GetChildAt(6);
        }
    }
}