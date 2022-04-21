/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_FarmItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_img_earth;
        public GImage m_img_lock;
        public GLoader m_img_quality;
        public GLoader m_img_icon;
        public GTextField m_txt_time;
        public GTextField m_txt_name;
        public GTextField m_txt_complete;
        public GLoader m_img_pquality;
        public GLoader m_img_picon;
        public GTextField m_txt_prepare;
        public GTextField m_txt_pname;
        public GImage m_img_forbid;
        public const string URL = "ui://wua6gzxlikzm1j";

        public static UI_FarmItemSkin CreateInstance()
        {
            return (UI_FarmItemSkin)UIPackage.CreateComponet("Home", "FarmItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_earth = (GImage)GetChildAt(0);
            m_img_lock = (GImage)GetChildAt(1);
            m_img_quality = (GLoader)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_txt_time = (GTextField)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_txt_complete = (GTextField)GetChildAt(6);
            m_img_pquality = (GLoader)GetChildAt(7);
            m_img_picon = (GLoader)GetChildAt(8);
            m_txt_prepare = (GTextField)GetChildAt(9);
            m_txt_pname = (GTextField)GetChildAt(10);
            m_img_forbid = (GImage)GetChildAt(11);
        }
    }
}