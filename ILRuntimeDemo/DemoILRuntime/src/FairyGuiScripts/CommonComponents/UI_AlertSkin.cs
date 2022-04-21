/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AlertSkin : GComponent
    {
        public Controller m_type;
        public UI_DialogBG4 m_bg;
        public UI_CommonBtn2Yellow m_btn_confirm;
        public UI_CommonBtn2Brown m_btn_cancel;
        public GRichTextField m_txt_tips;
        public const string URL = "ui://0qeyzr63pcjue";

        public static UI_AlertSkin CreateInstance()
        {
            return (UI_AlertSkin)UIPackage.CreateComponet("CommonComponents", "AlertSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (UI_DialogBG4)GetChildComAt(0);
            m_btn_confirm = (UI_CommonBtn2Yellow)GetChildComAt(1);
            m_btn_cancel = (UI_CommonBtn2Brown)GetChildComAt(2);
            m_txt_tips = (GRichTextField)GetChildAt(3);
        }
    }
}