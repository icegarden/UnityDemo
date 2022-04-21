/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrTextItem7Skin : GComponent
    {
        public GLoader m_img_icon;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_curValue;
        public const string URL = "ui://0qeyzr63h7466j";

        public static UI_AttrTextItem7Skin CreateInstance()
        {
            return (UI_AttrTextItem7Skin)UIPackage.CreateComponet("CommonComponents", "AttrTextItem7Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_name = (GRichTextField)GetChildAt(1);
            m_txt_curValue = (GRichTextField)GetChildAt(2);
        }
    }
}