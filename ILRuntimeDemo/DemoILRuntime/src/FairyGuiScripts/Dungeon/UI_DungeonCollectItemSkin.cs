/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonCollectItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public GImage m_n2;
        public GRichTextField m_txt_count;
        public const string URL = "ui://uwx2vhvssig22s";

        public static UI_DungeonCollectItemSkin CreateInstance()
        {
            return (UI_DungeonCollectItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonCollectItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
        }
    }
}