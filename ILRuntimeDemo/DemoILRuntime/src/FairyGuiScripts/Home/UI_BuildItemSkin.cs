/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_BuildItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_bg;
        public GLoader m_img_icon;
        public GImage m_n8;
        public GImage m_n7;
        public GImage m_img_show;
        public GTextField m_txt_show;
        public GTextField m_txt_level;
        public GTextField m_txt_name;
        public const string URL = "ui://wua6gzxlikzm1z";

        public static UI_BuildItemSkin CreateInstance()
        {
            return (UI_BuildItemSkin)UIPackage.CreateComponet("Home", "BuildItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_n8 = (GImage)GetChildAt(2);
            m_n7 = (GImage)GetChildAt(3);
            m_img_show = (GImage)GetChildAt(4);
            m_txt_show = (GTextField)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_txt_name = (GTextField)GetChildAt(7);
        }
    }
}