/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaDataSkin : GComponent
    {
        public GLabel m_bg;
        public UI_ArenaPlayerDataSkin m_item_mine;
        public UI_ArenaPlayerDataSkin m_item_enemy;
        public const string URL = "ui://m8qegzmncnj3b";

        public static UI_ArenaDataSkin CreateInstance()
        {
            return (UI_ArenaDataSkin)UIPackage.CreateComponet("Arena", "ArenaDataSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_item_mine = (UI_ArenaPlayerDataSkin)GetChildComAt(1);
            m_item_enemy = (UI_ArenaPlayerDataSkin)GetChildComAt(2);
        }
    }
}