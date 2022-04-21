/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonRelicsCardSkin : GButton
    {
        public Controller m_button;
        public GImage m_n1;
        public GImage m_n2;
        public GRichTextField m_txt_desc;
        public GRichTextField m_txt_name;
        public GImage m_img_new;
        public GComponent m_item;
        public const string URL = "ui://uwx2vhvssig23l";

        public static UI_DungeonRelicsCardSkin CreateInstance()
        {
            return (UI_DungeonRelicsCardSkin)UIPackage.CreateComponet("Dungeon", "DungeonRelicsCardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n1 = (GImage)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_desc = (GRichTextField)GetChildAt(2);
            m_txt_name = (GRichTextField)GetChildAt(3);
            m_img_new = (GImage)GetChildAt(4);
            m_item = (GComponent)GetChildComAt(5);
        }
    }
}