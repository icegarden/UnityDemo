/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonRelicsTipSkin : GComponent
    {
        public GImage m_n2;
        public GImage m_n4;
        public GComponent m_item;
        public GRichTextField m_txt_name;
        public GLabel m_txt_desc;
        public const string URL = "ui://uwx2vhvssig238";

        public static UI_DungeonRelicsTipSkin CreateInstance()
        {
            return (UI_DungeonRelicsTipSkin)UIPackage.CreateComponet("Dungeon", "DungeonRelicsTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n2 = (GImage)GetChildAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_item = (GComponent)GetChildComAt(2);
            m_txt_name = (GRichTextField)GetChildAt(3);
            m_txt_desc = (GLabel)GetChildComAt(4);
        }
    }
}