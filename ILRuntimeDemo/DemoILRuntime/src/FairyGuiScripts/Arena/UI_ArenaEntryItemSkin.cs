/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaEntryItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_slot;
        public GLoader m_img_icon;
        public GImage m_n9;
        public GLoader m_img_title;
        public GList m_list_reward;
        public GRichTextField m_txt_time;
        public const string URL = "ui://m8qegzmncnj33";

        public static UI_ArenaEntryItemSkin CreateInstance()
        {
            return (UI_ArenaEntryItemSkin)UIPackage.CreateComponet("Arena", "ArenaEntryItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_slot = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n9 = (GImage)GetChildAt(3);
            m_img_title = (GLoader)GetChildAt(4);
            m_list_reward = (GList)GetChildComAt(5);
            m_txt_time = (GRichTextField)GetChildAt(6);
        }
    }
}