/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Tree
{
    public partial class UI_TreeAlertSkin : GComponent
    {
        public Controller m_control;
        public GLabel m_bg;
        public GImage m_n10;
        public GTextField m_txt_0;
        public GComponent m_item_cost;
        public GComponent m_item_cost2;
        public GGroup m_n17;
        public GTextField m_txt_1;
        public GTextField m_txt_2;
        public GTextField m_txt_3;
        public GTextField m_txt_4;
        public GLoader m_icon_cost;
        public GLoader m_icon_cost2;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n7;
        public const string URL = "ui://jj5xd8f5mde4s";

        public static UI_TreeAlertSkin CreateInstance()
        {
            return (UI_TreeAlertSkin)UIPackage.CreateComponet("Tree", "TreeAlertSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n10 = (GImage)GetChildAt(1);
            m_txt_0 = (GTextField)GetChildAt(2);
            m_item_cost = (GComponent)GetChildComAt(3);
            m_item_cost2 = (GComponent)GetChildComAt(4);
            m_n17 = (GGroup)GetChildAt(5);
            m_txt_1 = (GTextField)GetChildAt(6);
            m_txt_2 = (GTextField)GetChildAt(7);
            m_txt_3 = (GTextField)GetChildAt(8);
            m_txt_4 = (GTextField)GetChildAt(9);
            m_icon_cost = (GLoader)GetChildAt(10);
            m_icon_cost2 = (GLoader)GetChildAt(11);
            m_btn_confirm = (GButton)GetChildComAt(12);
            m_btn_cancel = (GButton)GetChildComAt(13);
            m_n7 = (GGroup)GetChildAt(14);
        }
    }
}