/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CostSlot2Skin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GImage m_n5;
        public GRichTextField m_txt_count;
        public const string URL = "ui://0qeyzr63oii81m";

        public static UI_CostSlot2Skin CreateInstance()
        {
            return (UI_CostSlot2Skin)UIPackage.CreateComponet("CommonComponents", "CostSlot2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_txt_count = (GRichTextField)GetChildAt(4);
        }
    }
}