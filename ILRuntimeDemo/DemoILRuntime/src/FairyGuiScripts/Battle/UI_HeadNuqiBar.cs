/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_HeadNuqiBar : GComponent
    {
        public GImage m_bg;
        public const string URL = "ui://ej3y9mmyez5ub6";

        public static UI_HeadNuqiBar CreateInstance()
        {
            return (UI_HeadNuqiBar)UIPackage.CreateComponet("Battle", "HeadNuqiBar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
        }
    }
}