/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonUnlockTipSkin : GComponent
    {
        public GImage m_bg;
        public GTextField m_title;
        public GList m_list_item;
        public const string URL = "ui://uwx2vhvsj3ji48";

        public static UI_DungeonUnlockTipSkin CreateInstance()
        {
            return (UI_DungeonUnlockTipSkin)UIPackage.CreateComponet("Dungeon", "DungeonUnlockTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_title = (GTextField)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
        }
    }
}