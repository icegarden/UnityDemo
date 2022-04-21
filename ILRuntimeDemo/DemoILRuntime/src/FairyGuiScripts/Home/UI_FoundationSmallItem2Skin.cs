/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_FoundationSmallItem2Skin : GComponent
    {
        public Controller m_state;
        public GImage m_img_foundation;
        public GImage m_img_mask;
        public GImage m_img_lock;
        public GImage m_img_light;
        public GLoader m_img_building;
        public GImage m_n5;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public const string URL = "ui://wua6gzxlikzm1x";

        public static UI_FoundationSmallItem2Skin CreateInstance()
        {
            return (UI_FoundationSmallItem2Skin)UIPackage.CreateComponet("Home", "FoundationSmallItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_foundation = (GImage)GetChildAt(0);
            m_img_mask = (GImage)GetChildAt(1);
            m_img_lock = (GImage)GetChildAt(2);
            m_img_light = (GImage)GetChildAt(3);
            m_img_building = (GLoader)GetChildAt(4);
            m_n5 = (GImage)GetChildAt(5);
            m_txt_name = (GTextField)GetChildAt(6);
            m_txt_level = (GTextField)GetChildAt(7);
        }
    }
}