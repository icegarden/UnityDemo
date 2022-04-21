/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_BossListPanelSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_bottom;
        public GLabel m_title;
        public GButton m_btn_back;
        public GList m_list_item;
        public const string URL = "ui://etkvbnyek73k0";

        public static UI_BossListPanelSkin CreateInstance()
        {
            return (UI_BossListPanelSkin)UIPackage.CreateComponet("Boss", "BossListPanelSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_btn_back = (GButton)GetChildComAt(3);
            m_list_item = (GList)GetChildComAt(4);
        }
    }
}