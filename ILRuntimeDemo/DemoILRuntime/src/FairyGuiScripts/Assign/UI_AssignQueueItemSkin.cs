/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignQueueItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n11;
        public GImage m_n23;
        public GImage m_mask;
        public GLoader m_img_quality;
        public GLoader m_img_icon;
        public GRichTextField m_txt_unlock;
        public GTextField m_txt_empty;
        public GTextField m_txt_name;
        public GTextField m_txt_time;
        public GProgressBar m_pb_time;
        public GImage m_n17;
        public GImage m_n18;
        public GImage m_n19;
        public GImage m_n25;
        public GButton m_btn_take;
        public const string URL = "ui://e8jsnjd3gikd3";

        public static UI_AssignQueueItemSkin CreateInstance()
        {
            return (UI_AssignQueueItemSkin)UIPackage.CreateComponet("Assign", "AssignQueueItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n11 = (GImage)GetChildAt(0);
            m_n23 = (GImage)GetChildAt(1);
            m_mask = (GImage)GetChildAt(2);
            m_img_quality = (GLoader)GetChildAt(3);
            m_img_icon = (GLoader)GetChildAt(4);
            m_txt_unlock = (GRichTextField)GetChildAt(5);
            m_txt_empty = (GTextField)GetChildAt(6);
            m_txt_name = (GTextField)GetChildAt(7);
            m_txt_time = (GTextField)GetChildAt(8);
            m_pb_time = (GProgressBar)GetChildComAt(9);
            m_n17 = (GImage)GetChildAt(10);
            m_n18 = (GImage)GetChildAt(11);
            m_n19 = (GImage)GetChildAt(12);
            m_n25 = (GImage)GetChildAt(13);
            m_btn_take = (GButton)GetChildComAt(14);
        }
    }
}