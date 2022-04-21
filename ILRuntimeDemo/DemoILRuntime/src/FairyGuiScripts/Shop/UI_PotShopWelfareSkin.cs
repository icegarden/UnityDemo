/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_PotShopWelfareSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n2;
        public GTextField m_n3;
        public GTextField m_txt_time;
        public GList m_list_item;
        public const string URL = "ui://v22o2wamycl77";

        public static UI_PotShopWelfareSkin CreateInstance()
        {
            return (UI_PotShopWelfareSkin)UIPackage.CreateComponet("Shop", "PotShopWelfareSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_n3 = (GTextField)GetChildAt(2);
            m_txt_time = (GTextField)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
        }
    }
}