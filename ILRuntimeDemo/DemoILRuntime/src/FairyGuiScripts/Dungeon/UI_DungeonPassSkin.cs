/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonPassSkin : GComponent
    {
        public Controller m_isEnd;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n7;
        public GImage m_n1;
        public GImage m_n0;
        public GImage m_n13;
        public GImage m_n8;
        public GList m_list_item;
        public GRichTextField m_txt_itemName;
        public GRichTextField m_txt_itemCount;
        public GLoader m_icon_item;
        public GButton m_btn_end;
        public const string URL = "ui://uwx2vhvssig23m";

        public static UI_DungeonPassSkin CreateInstance()
        {
            return (UI_DungeonPassSkin)UIPackage.CreateComponet("Dungeon", "DungeonPassSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_isEnd = GetControllerAt(0);
            m_n2 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n1 = (GImage)GetChildAt(3);
            m_n0 = (GImage)GetChildAt(4);
            m_n13 = (GImage)GetChildAt(5);
            m_n8 = (GImage)GetChildAt(6);
            m_list_item = (GList)GetChildComAt(7);
            m_txt_itemName = (GRichTextField)GetChildAt(8);
            m_txt_itemCount = (GRichTextField)GetChildAt(9);
            m_icon_item = (GLoader)GetChildAt(10);
            m_btn_end = (GButton)GetChildComAt(11);
        }
    }
}