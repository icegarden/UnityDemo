/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonLogItemSkin : GComponent
    {
        public GTextField m_txt_time;
        public GRichTextField m_txt_content;
        public const string URL = "ui://uwx2vhvssig22n";

        public static UI_DungeonLogItemSkin CreateInstance()
        {
            return (UI_DungeonLogItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonLogItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_time = (GTextField)GetChildAt(0);
            m_txt_content = (GRichTextField)GetChildAt(1);
        }
    }
}