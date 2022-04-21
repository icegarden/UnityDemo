/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_FoundationItem2Skin : GComponent
    {
        public Controller m_state;
        public GImage m_img_mask;
        public GImage m_img_lock;
        public GButton m_btn_tap;
        public GLoader m_img_building;
        public GImage m_n5;
        public GTextField m_txt_name;
        public const string URL = "ui://wua6gzxlikzm16";

        public static UI_FoundationItem2Skin CreateInstance()
        {
            return (UI_FoundationItem2Skin)UIPackage.CreateComponet("Home", "FoundationItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_mask = (GImage)GetChildAt(0);
            m_img_lock = (GImage)GetChildAt(1);
            m_btn_tap = (GButton)GetChildComAt(2);
            m_img_building = (GLoader)GetChildAt(3);
            m_n5 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
        }
    }
}