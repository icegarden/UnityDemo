/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_ColorStarSkin : GComponent
    {
        public GImage m_n0;
        public const string URL = "ui://em095moes3fi9q";

        public static UI_ColorStarSkin CreateInstance()
        {
            return (UI_ColorStarSkin)UIPackage.CreateComponet("Pet", "ColorStarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
        }
    }
}