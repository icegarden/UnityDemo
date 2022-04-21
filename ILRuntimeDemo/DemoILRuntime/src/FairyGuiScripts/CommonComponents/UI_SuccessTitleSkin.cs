/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_SuccessTitleSkin : GLabel
    {
        public GImage m_n2;
        public GLoader m_icon;
        public const string URL = "ui://0qeyzr63xxxi51";

        public static UI_SuccessTitleSkin CreateInstance()
        {
            return (UI_SuccessTitleSkin)UIPackage.CreateComponet("CommonComponents", "SuccessTitleSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
        }
    }
}