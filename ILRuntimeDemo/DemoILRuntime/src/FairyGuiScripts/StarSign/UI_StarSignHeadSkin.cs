/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarSignHeadSkin : GComponent
    {
        public GButton m_img_head;
        public GImage m_img_bg;
        public GImage m_img_unlock;
        public const string URL = "ui://xplmw3njho4vp";

        public static UI_StarSignHeadSkin CreateInstance()
        {
            return (UI_StarSignHeadSkin)UIPackage.CreateComponet("StarSign", "StarSignHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_head = (GButton)GetChildComAt(0);
            m_img_bg = (GImage)GetChildAt(1);
            m_img_unlock = (GImage)GetChildAt(2);
        }
    }
}