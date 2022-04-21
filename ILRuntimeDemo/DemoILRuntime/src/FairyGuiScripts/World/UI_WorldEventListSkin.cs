/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEventListSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_top;
        public GList m_list_tab;
        public GList m_list_event;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public const string URL = "ui://63ubk2jodibib";

        public static UI_WorldEventListSkin CreateInstance()
        {
            return (UI_WorldEventListSkin)UIPackage.CreateComponet("World", "WorldEventListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_top = (GLoader)GetChildAt(1);
            m_list_tab = (GList)GetChildComAt(2);
            m_list_event = (GList)GetChildComAt(3);
            m_btn_left = (GButton)GetChildComAt(4);
            m_btn_right = (GButton)GetChildComAt(5);
        }
    }
}