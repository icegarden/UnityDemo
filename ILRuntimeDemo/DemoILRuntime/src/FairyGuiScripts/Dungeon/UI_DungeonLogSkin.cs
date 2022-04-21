/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonLogSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public const string URL = "ui://uwx2vhvssig22m";

        public static UI_DungeonLogSkin CreateInstance()
        {
            return (UI_DungeonLogSkin)UIPackage.CreateComponet("Dungeon", "DungeonLogSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
        }
    }
}