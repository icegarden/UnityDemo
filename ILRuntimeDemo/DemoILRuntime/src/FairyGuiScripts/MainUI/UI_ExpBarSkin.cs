/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainUI
{
    public partial class UI_ExpBarSkin : GProgressBar
    {
        public GLoader m_bg;
        public GLoader m_bar;
        public const string URL = "ui://eb1q6ro1gark2";

        public static UI_ExpBarSkin CreateInstance()
        {
            return (UI_ExpBarSkin)UIPackage.CreateComponet("MainUI", "ExpBarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_bar = (GLoader)GetChildAt(1);
        }
    }
}