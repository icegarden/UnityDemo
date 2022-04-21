/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonPassItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public GTextField m_txt_count;
        public GTextField m_txt_name;
        public GTextField m_txt_score;
        public const string URL = "ui://uwx2vhvssig23n";

        public static UI_DungeonPassItemSkin CreateInstance()
        {
            return (UI_DungeonPassItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonPassItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_count = (GTextField)GetChildAt(1);
            m_txt_name = (GTextField)GetChildAt(2);
            m_txt_score = (GTextField)GetChildAt(3);
        }
    }
}