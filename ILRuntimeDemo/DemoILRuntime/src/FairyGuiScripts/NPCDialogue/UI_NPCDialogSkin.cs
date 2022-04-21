/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace NPCDialogue
{
    public partial class UI_NPCDialogSkin : GComponent
    {
        public Controller m_type;
        public GLoader m_img_bg;
        public GComponent m_npc_left;
        public GComponent m_npc_right;
        public GLoader m_img_bottom;
        public GImage m_n4;
        public GTextField m_txt_name;
        public GLabel m_txt_content;
        public GList m_list_option;
        public GButton m_btn_skip;
        public const string URL = "ui://0dkdlrs3j3ji3";

        public static UI_NPCDialogSkin CreateInstance()
        {
            return (UI_NPCDialogSkin)UIPackage.CreateComponet("NPCDialogue", "NPCDialogSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_npc_left = (GComponent)GetChildComAt(1);
            m_npc_right = (GComponent)GetChildComAt(2);
            m_img_bottom = (GLoader)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_txt_content = (GLabel)GetChildComAt(6);
            m_list_option = (GList)GetChildComAt(7);
            m_btn_skip = (GButton)GetChildComAt(8);
        }
    }
}