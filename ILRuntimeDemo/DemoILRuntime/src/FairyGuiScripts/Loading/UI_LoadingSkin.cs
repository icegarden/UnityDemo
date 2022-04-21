/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Loading
{
    public partial class UI_LoadingSkin : GComponent
    {
        public GLoader m_bg;
        public UI_LoadingBar m_pb_loading;
        public GTextField m_txt_tips;
        public GTextField m_txt_notice;
        public const string URL = "ui://x0wur3di9fvw0";

        public static UI_LoadingSkin CreateInstance()
        {
            return (UI_LoadingSkin)UIPackage.CreateComponet("Loading", "LoadingSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_pb_loading = (UI_LoadingBar)GetChildComAt(1);
            m_txt_tips = (GTextField)GetChildAt(2);
            m_txt_notice = (GTextField)GetChildAt(3);
        }
    }
}