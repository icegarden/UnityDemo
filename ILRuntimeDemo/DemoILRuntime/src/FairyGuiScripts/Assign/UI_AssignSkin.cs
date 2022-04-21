/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_center;
        public GLoader m_img_bottom;
        public GLabel m_title;
        public GButton m_btn_back;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public GList m_list_tab;
        public UI_AssignQueueItemSkin m_item_0;
        public UI_AssignQueueItemSkin m_item_1;
        public UI_AssignQueueItemSkin m_item_2;
        public UI_AssignQueueItemSkin m_item_3;
        public UI_AssignQueueItemSkin m_item_4;
        public const string URL = "ui://e8jsnjd3gikd6";

        public static UI_AssignSkin CreateInstance()
        {
            return (UI_AssignSkin)UIPackage.CreateComponet("Assign", "AssignSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_center = (GLoader)GetChildAt(1);
            m_img_bottom = (GLoader)GetChildAt(2);
            m_title = (GLabel)GetChildComAt(3);
            m_btn_back = (GButton)GetChildComAt(4);
            m_btn_left = (GButton)GetChildComAt(5);
            m_btn_right = (GButton)GetChildComAt(6);
            m_list_tab = (GList)GetChildComAt(7);
            m_item_0 = (UI_AssignQueueItemSkin)GetChildComAt(8);
            m_item_1 = (UI_AssignQueueItemSkin)GetChildComAt(9);
            m_item_2 = (UI_AssignQueueItemSkin)GetChildComAt(10);
            m_item_3 = (UI_AssignQueueItemSkin)GetChildComAt(11);
            m_item_4 = (UI_AssignQueueItemSkin)GetChildComAt(12);
        }
    }
}