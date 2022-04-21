/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatChannelRender : GComponent
    {
        public Controller m_chatChannel;
        public GImage m_bg_normal;
        public GImage m_bg_selected;
        public GImage m_icon_world;
        public GImage m_icon_local;
        public GTextField m_tf_title;
        public GTextField m_tf_content;
        public GTextField m_tf_time;
        public const string URL = "ui://or7keldwlwv56";

        public static UI_ChatChannelRender CreateInstance()
        {
            return (UI_ChatChannelRender)UIPackage.CreateComponet("Chat", "ChatChannelRender");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_chatChannel = GetControllerAt(0);
            m_bg_normal = (GImage)GetChildAt(0);
            m_bg_selected = (GImage)GetChildAt(1);
            m_icon_world = (GImage)GetChildAt(2);
            m_icon_local = (GImage)GetChildAt(3);
            m_tf_title = (GTextField)GetChildAt(4);
            m_tf_content = (GTextField)GetChildAt(5);
            m_tf_time = (GTextField)GetChildAt(6);
        }
    }
}