/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonSummonEventSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GImage m_n3;
        public GImage m_n4;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_tip;
        public GList m_list_item;
        public GButton m_btn_summon;
        public const string URL = "ui://uwx2vhvssig231";

        public static UI_DungeonSummonEventSkin CreateInstance()
        {
            return (UI_DungeonSummonEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonSummonEventSkin");
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
            m_btn_summon = (GButton)GetChildComAt(7);
        }
    }
}