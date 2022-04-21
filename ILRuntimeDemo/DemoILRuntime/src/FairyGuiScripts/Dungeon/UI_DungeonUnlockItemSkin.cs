/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonUnlockItemSkin : GComponent
    {
        public GImage m_n4;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_progress;
        public const string URL = "ui://uwx2vhvsj3ji49";

        public static UI_DungeonUnlockItemSkin CreateInstance()
        {
            return (UI_DungeonUnlockItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonUnlockItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n4 = (GImage)GetChildAt(0);
            m_txt_desc = (GRichTextField)GetChildAt(1);
            m_txt_progress = (GRichTextField)GetChildAt(2);
        }
    }
}