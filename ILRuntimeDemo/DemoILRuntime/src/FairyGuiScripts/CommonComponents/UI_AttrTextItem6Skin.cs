/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrTextItem6Skin : GComponent
    {
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public GLoader m_img_icon;
        public const string URL = "ui://0qeyzr63k73k6e";

        public static UI_AttrTextItem6Skin CreateInstance()
        {
            return (UI_AttrTextItem6Skin)UIPackage.CreateComponet("CommonComponents", "AttrTextItem6Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_name = (GRichTextField)GetChildAt(0);
            m_txt_value = (GRichTextField)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
        }
    }
}