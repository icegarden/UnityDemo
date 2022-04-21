/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatChannelSkin : GComponent
    {
        public GImage m_img_bg;
        public GImage m_n5;
        public GList m_list_channel;
        public GTextField m_tf_title;
        public const string URL = "ui://or7keldwlwv57";

        public static UI_ChatChannelSkin CreateInstance()
        {
            return (UI_ChatChannelSkin)UIPackage.CreateComponet("Chat", "ChatChannelSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_list_channel = (GList)GetChildComAt(2);
            m_tf_title = (GTextField)GetChildAt(3);
        }
    }
}