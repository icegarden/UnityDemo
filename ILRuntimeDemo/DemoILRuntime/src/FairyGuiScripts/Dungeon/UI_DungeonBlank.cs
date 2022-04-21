/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonBlank : GComponent
    {
        public GImage m_img;
        public const string URL = "ui://uwx2vhvshioo21";

        public static UI_DungeonBlank CreateInstance()
        {
            return (UI_DungeonBlank)UIPackage.CreateComponet("Dungeon", "DungeonBlank");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img = (GImage)GetChildAt(0);
        }
    }
}