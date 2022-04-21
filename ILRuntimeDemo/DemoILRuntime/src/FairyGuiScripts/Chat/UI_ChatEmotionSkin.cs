/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatEmotionSkin : GComponent
    {
        public GImage m_n10;
        public GImage m_n9;
        public GList m_list_emotion;
        public GGraph m_n13;
        public UI_emobtn2 m_btn_0;
        public UI_emobtn2 m_btn_1;
        public const string URL = "ui://or7keldwlwv55";

        public static UI_ChatEmotionSkin CreateInstance()
        {
            return (UI_ChatEmotionSkin)UIPackage.CreateComponet("Chat", "ChatEmotionSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n10 = (GImage)GetChildAt(0);
            m_n9 = (GImage)GetChildAt(1);
            m_list_emotion = (GList)GetChildComAt(2);
            m_n13 = (GGraph)GetChildAt(3);
            m_btn_0 = (UI_emobtn2)GetChildComAt(4);
            m_btn_1 = (UI_emobtn2)GetChildComAt(5);
        }
    }
}