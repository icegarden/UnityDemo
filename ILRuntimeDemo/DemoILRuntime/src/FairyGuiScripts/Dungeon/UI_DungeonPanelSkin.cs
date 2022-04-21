/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonPanelSkin : GComponent
    {
        public GLoader m_img_bg;
        public GList m_list_dungeon;
        public GLabel m_title;
        public GButton m_btn_back;
        public const string URL = "ui://uwx2vhvshioo0";

        public static UI_DungeonPanelSkin CreateInstance()
        {
            return (UI_DungeonPanelSkin)UIPackage.CreateComponet("Dungeon", "DungeonPanelSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_list_dungeon = (GList)GetChildComAt(1);
            m_title = (GLabel)GetChildComAt(2);
            m_btn_back = (GButton)GetChildComAt(3);
        }
    }
}