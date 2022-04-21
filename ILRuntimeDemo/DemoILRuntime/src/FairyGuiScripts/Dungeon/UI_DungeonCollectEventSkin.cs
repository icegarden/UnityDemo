/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonCollectEventSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_img_bg;
        public GImage m_n5;
        public GImage m_n6;
        public GList m_list_item;
        public GList m_list_select;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_tip;
        public GButton m_btn_putin;
        public const string URL = "ui://uwx2vhvssig22q";

        public static UI_DungeonCollectEventSkin CreateInstance()
        {
            return (UI_DungeonCollectEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonCollectEventSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_img_bg = (GImage)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_n6 = (GImage)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_list_select = (GList)GetChildComAt(5);
            m_txt_desc = (GRichTextField)GetChildAt(6);
            m_txt_tip = (GTextField)GetChildAt(7);
            m_btn_putin = (GButton)GetChildComAt(8);
        }
    }
}