/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HarvestSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_shading;
        public GImage m_n3;
        public GTextField m_n4;
        public GList m_list_item;
        public GComponent m_btn_close;
        public GButton m_btn_harvest;
        public GGroup m_n8;
        public const string URL = "ui://wua6gzxlikzm1p";

        public static UI_HarvestSkin CreateInstance()
        {
            return (UI_HarvestSkin)UIPackage.CreateComponet("Home", "HarvestSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_shading = (GLoader)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n4 = (GTextField)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_btn_close = (GComponent)GetChildComAt(5);
            m_btn_harvest = (GButton)GetChildComAt(6);
            m_n8 = (GGroup)GetChildAt(7);
        }
    }
}