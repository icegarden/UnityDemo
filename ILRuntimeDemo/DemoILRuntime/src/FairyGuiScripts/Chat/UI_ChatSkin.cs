/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatSkin : GComponent
    {
        public UI_ChatChannelSkin m_skin_channel;
        public GLoader m_img_bg;
        public GList m_list_content;
        public GImage m_n18;
        public GImage m_n13;
        public GTextInput m_txt_inputtip;
        public GTextInput m_txt_input;
        public UI_emobtn m_btn_emo;
        public UI_sendBtn m_btn_send;
        public GGroup m_group_bottom;
        public GImage m_n17;
        public UI_closebtn m_btn_close;
        public UI_openbtn m_btn_open;
        public GTextField m_tf_title;
        public GGroup m_group_top;
        public GGroup m_group_content;
        public UI_Button1 m_btn_chat;
        public const string URL = "ui://or7keldwlwv50";

        public static UI_ChatSkin CreateInstance()
        {
            return (UI_ChatSkin)UIPackage.CreateComponet("Chat", "ChatSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_skin_channel = (UI_ChatChannelSkin)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_list_content = (GList)GetChildComAt(2);
            m_n18 = (GImage)GetChildAt(3);
            m_n13 = (GImage)GetChildAt(4);
            m_txt_inputtip = (GTextInput)GetChildAt(5);
            m_txt_input = (GTextInput)GetChildAt(6);
            m_btn_emo = (UI_emobtn)GetChildComAt(7);
            m_btn_send = (UI_sendBtn)GetChildComAt(8);
            m_group_bottom = (GGroup)GetChildAt(9);
            m_n17 = (GImage)GetChildAt(10);
            m_btn_close = (UI_closebtn)GetChildComAt(11);
            m_btn_open = (UI_openbtn)GetChildComAt(12);
            m_tf_title = (GTextField)GetChildAt(13);
            m_group_top = (GGroup)GetChildAt(14);
            m_group_content = (GGroup)GetChildAt(15);
            m_btn_chat = (UI_Button1)GetChildComAt(16);
        }
    }
}