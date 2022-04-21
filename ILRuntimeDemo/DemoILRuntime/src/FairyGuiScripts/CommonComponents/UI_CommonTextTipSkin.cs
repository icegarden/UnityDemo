/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonTextTipSkin : GComponent
    {
        public GImage m_n0;
        public GRichTextField m_txt_tip;
        public const string URL = "ui://0qeyzr63pcjud";

        public static UI_CommonTextTipSkin CreateInstance()
        {
            return (UI_CommonTextTipSkin)UIPackage.CreateComponet("CommonComponents", "CommonTextTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_txt_tip = (GRichTextField)GetChildAt(1);
        }
    }
}