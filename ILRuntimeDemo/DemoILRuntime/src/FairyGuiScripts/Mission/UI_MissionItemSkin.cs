/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mission
{
    public partial class UI_MissionItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_slotBg;
        public GLoader m_img_slot;
        public GImage m_n2;
        public GImage m_img_complete;
        public GTextField m_txt_count;
        public GTextField m_txt_name;
        public GProgressBar m_pb_count;
        public GButton m_btn_take;
        public GButton m_btn_goto;
        public const string URL = "ui://ew6i1be3sirwc";

        public static UI_MissionItemSkin CreateInstance()
        {
            return (UI_MissionItemSkin)UIPackage.CreateComponet("Mission", "MissionItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_slotBg = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_n2 = (GImage)GetChildAt(3);
            m_img_complete = (GImage)GetChildAt(4);
            m_txt_count = (GTextField)GetChildAt(5);
            m_txt_name = (GTextField)GetChildAt(6);
            m_pb_count = (GProgressBar)GetChildComAt(7);
            m_btn_take = (GButton)GetChildComAt(8);
            m_btn_goto = (GButton)GetChildComAt(9);
        }
    }
}