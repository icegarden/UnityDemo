/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonRelicsBtnGroup : GComponent
    {
        public GImage m_bg;
        public GButton m_btn_all;
        public GButton m_btn_lock;
        public GButton m_btn_has;
        public const string URL = "ui://uwx2vhvssig235";

        public static UI_DungeonRelicsBtnGroup CreateInstance()
        {
            return (UI_DungeonRelicsBtnGroup)UIPackage.CreateComponet("Dungeon", "DungeonRelicsBtnGroup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_btn_all = (GButton)GetChildComAt(1);
            m_btn_lock = (GButton)GetChildComAt(2);
            m_btn_has = (GButton)GetChildComAt(3);
        }
    }
}