/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrTextItem5Skin : GComponent
    {
        public GLoader m_img_icon;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public GImage m_line;
        public const string URL = "ui://0qeyzr63sig268";

        public static UI_AttrTextItem5Skin CreateInstance()
        {
            return (UI_AttrTextItem5Skin)UIPackage.CreateComponet("CommonComponents", "AttrTextItem5Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_name = (GRichTextField)GetChildAt(1);
            m_txt_value = (GRichTextField)GetChildAt(2);
            m_line = (GImage)GetChildAt(3);
        }
    }
}