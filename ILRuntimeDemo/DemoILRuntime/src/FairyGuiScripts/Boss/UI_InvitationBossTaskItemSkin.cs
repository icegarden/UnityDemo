/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_InvitationBossTaskItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GTextField m_txt_desc;
        public GProgressBar m_pb_count;
        public GList m_list_reward;
        public GButton m_btn_take;
        public GButton m_btn_uncompelete;
        public GImage m_img_complete;
        public GImage m_img_tag;
        public const string URL = "ui://etkvbnyek73kw";

        public static UI_InvitationBossTaskItemSkin CreateInstance()
        {
            return (UI_InvitationBossTaskItemSkin)UIPackage.CreateComponet("Boss", "InvitationBossTaskItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_txt_desc = (GTextField)GetChildAt(1);
            m_pb_count = (GProgressBar)GetChildComAt(2);
            m_list_reward = (GList)GetChildComAt(3);
            m_btn_take = (GButton)GetChildComAt(4);
            m_btn_uncompelete = (GButton)GetChildComAt(5);
            m_img_complete = (GImage)GetChildAt(6);
            m_img_tag = (GImage)GetChildAt(7);
        }
    }
}