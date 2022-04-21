/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_ClearDebrisSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_shading;
        public GImage m_n2;
        public GImage m_n7;
        public GTextField m_txt_name;
        public GTextField m_n8;
        public GList m_list_item;
        public GList m_list_cost;
        public GComponent m_btn_close;
        public GButton m_btn_clear;
        public const string URL = "ui://wua6gzxlikzm24";

        public static UI_ClearDebrisSkin CreateInstance()
        {
            return (UI_ClearDebrisSkin)UIPackage.CreateComponet("Home", "ClearDebrisSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_shading = (GLoader)GetChildAt(3);
            m_n2 = (GImage)GetChildAt(4);
            m_n7 = (GImage)GetChildAt(5);
            m_txt_name = (GTextField)GetChildAt(6);
            m_n8 = (GTextField)GetChildAt(7);
            m_list_item = (GList)GetChildComAt(8);
            m_list_cost = (GList)GetChildComAt(9);
            m_btn_close = (GComponent)GetChildComAt(10);
            m_btn_clear = (GButton)GetChildComAt(11);
        }
    }
}