/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonGridRoad5 : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://uwx2vhvshioo1u";

        public static UI_DungeonGridRoad5 CreateInstance()
        {
            return (UI_DungeonGridRoad5)UIPackage.CreateComponet("Dungeon", "DungeonGridRoad5");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}