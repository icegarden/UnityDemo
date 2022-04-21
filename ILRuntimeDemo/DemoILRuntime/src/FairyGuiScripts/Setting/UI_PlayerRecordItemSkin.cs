/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_PlayerRecordItemSkin : GComponent
    {
        public GImage m_n0;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://wi3k1s54fjwrq";

        public static UI_PlayerRecordItemSkin CreateInstance()
        {
            return (UI_PlayerRecordItemSkin)UIPackage.CreateComponet("Setting", "PlayerRecordItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_txt_desc = (GRichTextField)GetChildAt(1);
        }
    }
}