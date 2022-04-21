/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrTextItem1Skin : GComponent
    {
        public GImage m_bg;
        public GLoader m_img_icon;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public const string URL = "ui://0qeyzr63pcju18";

        public static UI_AttrTextItem1Skin CreateInstance()
        {
            return (UI_AttrTextItem1Skin)UIPackage.CreateComponet("CommonComponents", "AttrTextItem1Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_value = (GRichTextField)GetChildAt(3);
        }
    }
}