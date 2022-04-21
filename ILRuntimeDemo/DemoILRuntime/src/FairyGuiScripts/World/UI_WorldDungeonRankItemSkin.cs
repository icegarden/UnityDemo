/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldDungeonRankItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_rank;
        public GTextField m_txt_rank;
        public GList m_list_reward;
        public const string URL = "ui://63ubk2jodibip";

        public static UI_WorldDungeonRankItemSkin CreateInstance()
        {
            return (UI_WorldDungeonRankItemSkin)UIPackage.CreateComponet("World", "WorldDungeonRankItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_rank = (GLoader)GetChildAt(1);
            m_txt_rank = (GTextField)GetChildAt(2);
            m_list_reward = (GList)GetChildComAt(3);
        }
    }
}