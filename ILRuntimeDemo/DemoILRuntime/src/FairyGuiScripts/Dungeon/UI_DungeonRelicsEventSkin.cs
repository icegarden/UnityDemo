/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonRelicsEventSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n0;
        public GImage m_n3;
        public GList m_list_item;
        public GButton m_btn_bag;
        public const string URL = "ui://uwx2vhvssig23b";

        public static UI_DungeonRelicsEventSkin CreateInstance()
        {
            return (UI_DungeonRelicsEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonRelicsEventSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_n0 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_btn_bag = (GButton)GetChildComAt(5);
        }
    }
}