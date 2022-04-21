/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarFetterItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n1;
        public GImage m_n2;
        public GTextField m_txt_level;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public GImage m_n6;
        public const string URL = "ui://xplmw3njho4vx";

        public static UI_StarFetterItemSkin CreateInstance()
        {
            return (UI_StarFetterItemSkin)UIPackage.CreateComponet("StarSign", "StarFetterItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_level = (GTextField)GetChildAt(2);
            m_txt_name = (GRichTextField)GetChildAt(3);
            m_txt_desc = (GRichTextField)GetChildAt(4);
            m_n6 = (GImage)GetChildAt(5);
        }
    }
}