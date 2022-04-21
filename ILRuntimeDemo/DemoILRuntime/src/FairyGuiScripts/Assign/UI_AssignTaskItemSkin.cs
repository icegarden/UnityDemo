/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignTaskItemSkin : GButton
    {
        public Controller m_button;
        public GLoader m_img_bg;
        public GLoader m_img_tag;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_exp;
        public GRichTextField m_txt_type;
        public GRichTextField m_txt_time;
        public GComponent m_item_reward;
        public GButton m_btn_accept;
        public const string URL = "ui://e8jsnjd3gikd4";

        public static UI_AssignTaskItemSkin CreateInstance()
        {
            return (UI_AssignTaskItemSkin)UIPackage.CreateComponet("Assign", "AssignTaskItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_tag = (GLoader)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_exp = (GRichTextField)GetChildAt(3);
            m_txt_type = (GRichTextField)GetChildAt(4);
            m_txt_time = (GRichTextField)GetChildAt(5);
            m_item_reward = (GComponent)GetChildComAt(6);
            m_btn_accept = (GButton)GetChildComAt(7);
        }
    }
}