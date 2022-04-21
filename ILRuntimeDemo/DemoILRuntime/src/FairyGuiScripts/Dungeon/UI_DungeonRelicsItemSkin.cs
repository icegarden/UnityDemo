/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonRelicsItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GImage m_n7;
        public GImage m_n6;
        public GImage m_n4;
        public GTextField m_txt_count;
        public const string URL = "ui://uwx2vhvssig236";

        public static UI_DungeonRelicsItemSkin CreateInstance()
        {
            return (UI_DungeonRelicsItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonRelicsItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_n7 = (GImage)GetChildAt(3);
            m_n6 = (GImage)GetChildAt(4);
            m_n4 = (GImage)GetChildAt(5);
            m_txt_count = (GTextField)GetChildAt(6);
        }
    }
}