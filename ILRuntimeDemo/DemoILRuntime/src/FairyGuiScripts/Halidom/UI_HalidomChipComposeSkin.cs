/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomChipComposeSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GImage m_n55;
        public GImage m_n56;
        public GComponent m_item;
        public GProgressBar m_pb_count;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GRichTextField m_txt_needCount;
        public GRichTextField m_txt_effectDesc;
        public GRichTextField m_txt_effectCount;
        public GTextField m_txt_totalEffect;
        public GList m_list_baseAttr;
        public GList m_list_passiveAttr;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GButton m_btn_compose;
        public GButton m_btn_get;
        public const string URL = "ui://rqnkl6749hyny";

        public static UI_HalidomChipComposeSkin CreateInstance()
        {
            return (UI_HalidomChipComposeSkin)UIPackage.CreateComponet("Halidom", "HalidomChipComposeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n55 = (GImage)GetChildAt(1);
            m_n56 = (GImage)GetChildAt(2);
            m_item = (GComponent)GetChildComAt(3);
            m_pb_count = (GProgressBar)GetChildComAt(4);
            m_txt_tip1 = (GTextField)GetChildAt(5);
            m_txt_tip2 = (GTextField)GetChildAt(6);
            m_txt_needCount = (GRichTextField)GetChildAt(7);
            m_txt_effectDesc = (GRichTextField)GetChildAt(8);
            m_txt_effectCount = (GRichTextField)GetChildAt(9);
            m_txt_totalEffect = (GTextField)GetChildAt(10);
            m_list_baseAttr = (GList)GetChildComAt(11);
            m_list_passiveAttr = (GList)GetChildComAt(12);
            m_btn_left = (GButton)GetChildComAt(13);
            m_btn_right = (GButton)GetChildComAt(14);
            m_btn_compose = (GButton)GetChildComAt(15);
            m_btn_get = (GButton)GetChildComAt(16);
        }
    }
}