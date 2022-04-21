/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_PotShopWelfareItemSkin : GComponent
    {
        public GImage m_n1;
        public GRichTextField m_txt_desc;
        public GProgressBar m_pb_count;
        public GList m_list_reward;
        public const string URL = "ui://v22o2wamycl78";

        public static UI_PotShopWelfareItemSkin CreateInstance()
        {
            return (UI_PotShopWelfareItemSkin)UIPackage.CreateComponet("Shop", "PotShopWelfareItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_txt_desc = (GRichTextField)GetChildAt(1);
            m_pb_count = (GProgressBar)GetChildComAt(2);
            m_list_reward = (GList)GetChildComAt(3);
        }
    }
}