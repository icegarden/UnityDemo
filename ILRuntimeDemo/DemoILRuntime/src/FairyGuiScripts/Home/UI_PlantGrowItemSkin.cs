/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_PlantGrowItemSkin : GComponent
    {
        public Controller m_state;
        public GRichTextField m_txt_name;
        public GRichTextField m_n3;
        public GTextField m_txt_time;
        public GImage m_n5;
        public GImage m_n9;
        public GImage m_n6;
        public GImage m_n8;
        public const string URL = "ui://wua6gzxlikzm1m";

        public static UI_PlantGrowItemSkin CreateInstance()
        {
            return (UI_PlantGrowItemSkin)UIPackage.CreateComponet("Home", "PlantGrowItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_txt_name = (GRichTextField)GetChildAt(0);
            m_n3 = (GRichTextField)GetChildAt(1);
            m_txt_time = (GTextField)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_n9 = (GImage)GetChildAt(4);
            m_n6 = (GImage)GetChildAt(5);
            m_n8 = (GImage)GetChildAt(6);
        }
    }
}