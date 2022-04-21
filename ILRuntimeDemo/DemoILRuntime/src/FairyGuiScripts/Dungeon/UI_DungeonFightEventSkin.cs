/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonFightEventSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GImage m_n3;
        public GImage m_n4;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_tip;
        public GList m_list_item;
        public GButton m_btn_fight;
        public const string URL = "ui://uwx2vhvssig22z";

        public static UI_DungeonFightEventSkin CreateInstance()
        {
            return (UI_DungeonFightEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonFightEventSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n4 = (GImage)GetChildAt(3);
            m_txt_desc = (GRichTextField)GetChildAt(4);
            m_txt_tip = (GTextField)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
            m_btn_fight = (GButton)GetChildComAt(7);
        }
    }
}