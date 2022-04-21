/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatItemRenderSkin : GComponent
    {
        public Controller m_chatItem;
        public GImage m_bg_content;
        public GRichTextField m_tf_content;
        public GRichTextField m_tf_name;
        public GImage m_n14;
        public GLoader m_img_head;
        public GLoader m_img_border;
        public GTextField m_tf_lv;
        public GGroup m_group_head;
        public GImage m_bg_tip;
        public GRichTextField m_tf_tip;
        public const string URL = "ui://or7keldwlwv52p";

        public static UI_ChatItemRenderSkin CreateInstance()
        {
            return (UI_ChatItemRenderSkin)UIPackage.CreateComponet("Chat", "ChatItemRenderSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_chatItem = GetControllerAt(0);
            m_bg_content = (GImage)GetChildAt(0);
            m_tf_content = (GRichTextField)GetChildAt(1);
            m_tf_name = (GRichTextField)GetChildAt(2);
            m_n14 = (GImage)GetChildAt(3);
            m_img_head = (GLoader)GetChildAt(4);
            m_img_border = (GLoader)GetChildAt(5);
            m_tf_lv = (GTextField)GetChildAt(6);
            m_group_head = (GGroup)GetChildAt(7);
            m_bg_tip = (GImage)GetChildAt(8);
            m_tf_tip = (GRichTextField)GetChildAt(9);
        }
    }
}