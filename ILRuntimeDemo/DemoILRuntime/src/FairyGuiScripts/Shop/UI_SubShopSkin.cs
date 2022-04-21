/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_SubShopSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n2;
        public GTextField m_txt_refreshTime;
        public GButton m_btn_refresh;
        public GGroup m_gp_refresh;
        public GImage m_bg_desc;
        public GTextField m_txt_desc;
        public GList m_list_item;
        public GList m_list_tab;
        public const string URL = "ui://v22o2wamg7dec";

        public static UI_SubShopSkin CreateInstance()
        {
            return (UI_SubShopSkin)UIPackage.CreateComponet("Shop", "SubShopSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n2 = (GImage)GetChildAt(0);
            m_txt_refreshTime = (GTextField)GetChildAt(1);
            m_btn_refresh = (GButton)GetChildComAt(2);
            m_gp_refresh = (GGroup)GetChildAt(3);
            m_bg_desc = (GImage)GetChildAt(4);
            m_txt_desc = (GTextField)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
            m_list_tab = (GList)GetChildComAt(7);
        }
    }
}