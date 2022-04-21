/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_BuffIconSkin : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://0qeyzr63k73k6f";

        public static UI_BuffIconSkin CreateInstance()
        {
            return (UI_BuffIconSkin)UIPackage.CreateComponet("CommonComponents", "BuffIconSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}