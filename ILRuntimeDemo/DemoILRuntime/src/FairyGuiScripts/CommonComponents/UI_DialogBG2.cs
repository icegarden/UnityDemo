/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_DialogBG2 : GLabel
    {
        public GLoader m_img_bg1;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n11;
        public GTextField m_title;
        public UI_BackBtn m_btn_back;
        public const string URL = "ui://0qeyzr63pcjuf";

        public static UI_DialogBG2 CreateInstance()
        {
            return (UI_DialogBG2)UIPackage.CreateComponet("CommonComponents", "DialogBG2");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg1 = (GLoader)GetChildAt(0);
            m_img_bg2 = (GLoader)GetChildAt(1);
            m_img_top = (GLoader)GetChildAt(2);
            m_n11 = (GImage)GetChildAt(3);
            m_title = (GTextField)GetChildAt(4);
            m_btn_back = (UI_BackBtn)GetChildComAt(5);
        }
    }
}