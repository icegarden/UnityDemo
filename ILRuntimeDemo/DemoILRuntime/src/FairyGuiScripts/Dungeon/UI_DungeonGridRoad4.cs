/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonGridRoad4 : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://uwx2vhvshioo1t";

        public static UI_DungeonGridRoad4 CreateInstance()
        {
            return (UI_DungeonGridRoad4)UIPackage.CreateComponet("Dungeon", "DungeonGridRoad4");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}