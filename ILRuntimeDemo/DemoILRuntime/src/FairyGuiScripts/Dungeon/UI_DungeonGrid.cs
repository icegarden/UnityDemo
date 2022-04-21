/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonGrid : GComponent
    {
        public GLoader m_img_floor;
        public GImage m_img_selected;
        public GImage m_img_complete;
        public GLoader m_img_event;
        public const string URL = "ui://uwx2vhvshioo1m";

        public static UI_DungeonGrid CreateInstance()
        {
            return (UI_DungeonGrid)UIPackage.CreateComponet("Dungeon", "DungeonGrid");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_floor = (GLoader)GetChildAt(0);
            m_img_selected = (GImage)GetChildAt(1);
            m_img_complete = (GImage)GetChildAt(2);
            m_img_event = (GLoader)GetChildAt(3);
        }
    }
}