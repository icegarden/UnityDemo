/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldDungeonTipSkin : GComponent
    {
        public GImage m_n4;
        public GImage m_n5;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://63ubk2jodibiq";

        public static UI_WorldDungeonTipSkin CreateInstance()
        {
            return (UI_WorldDungeonTipSkin)UIPackage.CreateComponet("World", "WorldDungeonTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_n5 = (GImage)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_desc = (GRichTextField)GetChildAt(3);
        }
    }
}