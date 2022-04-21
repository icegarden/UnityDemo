/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarSignSkin : GComponent
    {
        public GLoader m_img_bg;
        public UI_StarSignMapSkin m_view_star;
        public GLabel m_title;
        public GLoader m_img_bottom;
        public GButton m_btn_back;
        public GButton m_btn_book;
        public const string URL = "ui://xplmw3njho4v7";

        public static UI_StarSignSkin CreateInstance()
        {
            return (UI_StarSignSkin)UIPackage.CreateComponet("StarSign", "StarSignSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_view_star = (UI_StarSignMapSkin)GetChildComAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_img_bottom = (GLoader)GetChildAt(3);
            m_btn_back = (GButton)GetChildComAt(4);
            m_btn_book = (GButton)GetChildComAt(5);
        }
    }
}