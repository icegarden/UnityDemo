/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_BuildInfoSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GImage m_n14;
        public GImage m_n7;
        public GTextField m_n8;
        public GRichTextField m_txt_desc;
        public GComponent m_btn_close;
        public const string URL = "ui://wua6gzxlikzm27";

        public static UI_BuildInfoSkin CreateInstance()
        {
            return (UI_BuildInfoSkin)UIPackage.CreateComponet("Home", "BuildInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_n7 = (GImage)GetChildAt(4);
            m_n8 = (GTextField)GetChildAt(5);
            m_txt_desc = (GRichTextField)GetChildAt(6);
            m_btn_close = (GComponent)GetChildComAt(7);
        }
    }
}