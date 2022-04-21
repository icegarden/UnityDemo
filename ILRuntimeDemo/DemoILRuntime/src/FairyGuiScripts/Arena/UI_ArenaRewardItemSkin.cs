/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRewardItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_level;
        public GImage m_n38;
        public GTextField m_txt_rank;
        public GList m_list_reward;
        public const string URL = "ui://m8qegzmncnj3j";

        public static UI_ArenaRewardItemSkin CreateInstance()
        {
            return (UI_ArenaRewardItemSkin)UIPackage.CreateComponet("Arena", "ArenaRewardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_level = (GLoader)GetChildAt(1);
            m_n38 = (GImage)GetChildAt(2);
            m_txt_rank = (GTextField)GetChildAt(3);
            m_list_reward = (GList)GetChildComAt(4);
        }
    }
}