/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HarvestItemSkin : GComponent
    {
        public GImage m_n8;
        public GImage m_n9;
        public GComponent m_item;
        public GButton m_btn_select;
        public GTextField m_n11;
        public GRichTextField m_txt_name;
        public GTextField m_txt_time;
        public const string URL = "ui://wua6gzxlikzm1r";

        public static UI_HarvestItemSkin CreateInstance()
        {
            return (UI_HarvestItemSkin)UIPackage.CreateComponet("Home", "HarvestItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n8 = (GImage)GetChildAt(0);
            m_n9 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_btn_select = (GButton)GetChildComAt(3);
            m_n11 = (GTextField)GetChildAt(4);
            m_txt_name = (GRichTextField)GetChildAt(5);
            m_txt_time = (GTextField)GetChildAt(6);
        }
    }
}