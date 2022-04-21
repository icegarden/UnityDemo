/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonGridRoad8 : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://uwx2vhvshioo1x";

        public static UI_DungeonGridRoad8 CreateInstance()
        {
            return (UI_DungeonGridRoad8)UIPackage.CreateComponet("Dungeon", "DungeonGridRoad8");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}