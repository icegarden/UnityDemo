/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonGridRoad10 : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://uwx2vhvshioo1z";

        public static UI_DungeonGridRoad10 CreateInstance()
        {
            return (UI_DungeonGridRoad10)UIPackage.CreateComponet("Dungeon", "DungeonGridRoad10");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}