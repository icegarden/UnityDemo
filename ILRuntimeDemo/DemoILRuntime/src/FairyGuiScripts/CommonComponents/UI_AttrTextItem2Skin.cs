/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrTextItem2Skin : GComponent
    {
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public const string URL = "ui://0qeyzr63pcjuc";

        public static UI_AttrTextItem2Skin CreateInstance()
        {
            return (UI_AttrTextItem2Skin)UIPackage.CreateComponet("CommonComponents", "AttrTextItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_name = (GRichTextField)GetChildAt(0);
            m_txt_value = (GRichTextField)GetChildAt(1);
        }
    }
}