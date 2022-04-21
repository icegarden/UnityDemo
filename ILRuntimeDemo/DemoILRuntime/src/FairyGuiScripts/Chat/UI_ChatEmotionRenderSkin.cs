/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Chat
{
    public partial class UI_ChatEmotionRenderSkin : GComponent
    {
        public GLoader m_img;
        public const string URL = "ui://or7keldwlwv59";

        public static UI_ChatEmotionRenderSkin CreateInstance()
        {
            return (UI_ChatEmotionRenderSkin)UIPackage.CreateComponet("Chat", "ChatEmotionRenderSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img = (GLoader)GetChildAt(0);
        }
    }
}