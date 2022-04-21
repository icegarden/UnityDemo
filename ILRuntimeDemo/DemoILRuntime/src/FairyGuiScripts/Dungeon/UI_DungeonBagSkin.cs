/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonBagSkin : GComponent
    {
        public Controller m_tab;
        public GLoader m_img_bg1;
        public GButton m_btn_relics;
        public GButton m_btn_hero;
        public GButton m_btn_bag;
        public GLoader m_img_bg2;
        public GLoader m_img_top;
        public GImage m_n9;
        public GImage m_n10;
        public GImage m_n23;
        public GTextField m_txt_title;
        public GTextField m_txt_relicsTip;
        public GTextField m_txt_relicsCount;
        public GTextField m_txt_heroTip;
        public GList m_list_relics;
        public GList m_list_pet;
        public GList m_list_item;
        public UI_DungeonRelicsBtnGroup m_com_info;
        public GButton m_btn_info;
        public GButton m_btn_back;
        public const string URL = "ui://uwx2vhvssig234";

        public static UI_DungeonBagSkin CreateInstance()
        {
            return (UI_DungeonBagSkin)UIPackage.CreateComponet("Dungeon", "DungeonBagSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_img_bg1 = (GLoader)GetChildAt(0);
            m_btn_relics = (GButton)GetChildComAt(1);
            m_btn_hero = (GButton)GetChildComAt(2);
            m_btn_bag = (GButton)GetChildComAt(3);
            m_img_bg2 = (GLoader)GetChildAt(4);
            m_img_top = (GLoader)GetChildAt(5);
            m_n9 = (GImage)GetChildAt(6);
            m_n10 = (GImage)GetChildAt(7);
            m_n23 = (GImage)GetChildAt(8);
            m_txt_title = (GTextField)GetChildAt(9);
            m_txt_relicsTip = (GTextField)GetChildAt(10);
            m_txt_relicsCount = (GTextField)GetChildAt(11);
            m_txt_heroTip = (GTextField)GetChildAt(12);
            m_list_relics = (GList)GetChildComAt(13);
            m_list_pet = (GList)GetChildComAt(14);
            m_list_item = (GList)GetChildComAt(15);
            m_com_info = (UI_DungeonRelicsBtnGroup)GetChildComAt(16);
            m_btn_info = (GButton)GetChildComAt(17);
            m_btn_back = (GButton)GetChildComAt(18);
        }
    }
}