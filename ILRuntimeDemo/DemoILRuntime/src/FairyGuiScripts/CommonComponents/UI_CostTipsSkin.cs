/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CostTipsSkin : GComponent
    {
        public UI_DialogBG4 m_bg;
        public GRichTextField m_txt_tips1;
        public GRichTextField m_txt_tips2;
        public GLoader m_img_icon;
        public UI_CommonBtn2Yellow m_btn_confirm;
        public UI_CommonBtn2Brown m_btn_cancel;
        public const string URL = "ui://0qeyzr63ikzm29";

        public static UI_CostTipsSkin CreateInstance()
        {
            return (UI_CostTipsSkin)UIPackage.CreateComponet("CommonComponents", "CostTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (UI_DialogBG4)GetChildComAt(0);
            m_txt_tips1 = (GRichTextField)GetChildAt(1);
            m_txt_tips2 = (GRichTextField)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_btn_confirm = (UI_CommonBtn2Yellow)GetChildComAt(4);
            m_btn_cancel = (UI_CommonBtn2Brown)GetChildComAt(5);
        }
    }
}