/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_BossEntryItemSkin : GComponent
    {
        public GLoader m_img_banner;
        public GImage m_n8;
        public GImage m_n1;
        public GLoader m_img_boss;
        public GLoader m_img_name;
        public GList m_list_reward;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://etkvbnyek73k8";

        public static UI_BossEntryItemSkin CreateInstance()
        {
            return (UI_BossEntryItemSkin)UIPackage.CreateComponet("Boss", "BossEntryItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_banner = (GLoader)GetChildAt(0);
            m_n8 = (GImage)GetChildAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_img_boss = (GLoader)GetChildAt(3);
            m_img_name = (GLoader)GetChildAt(4);
            m_list_reward = (GList)GetChildComAt(5);
            m_txt_desc = (GRichTextField)GetChildAt(6);
        }
    }
}