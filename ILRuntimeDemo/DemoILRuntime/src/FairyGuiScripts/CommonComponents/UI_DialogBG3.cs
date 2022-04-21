/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_DialogBG3 : GLabel
    {
        public GLoader m_img_bg;
        public GTextField m_title;
        public const string URL = "ui://0qeyzr63g1mw5p";

        public static UI_DialogBG3 CreateInstance()
        {
            return (UI_DialogBG3)UIPackage.CreateComponet("CommonComponents", "DialogBG3");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
        }
    }
}