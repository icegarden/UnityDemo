/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_PotTipSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GImage m_n5;
        public GImage m_n8;
        public GTextField m_n7;
        public GTextField m_n3;
        public GTextField m_n10;
        public GLabel m_txt_desc;
        public GList m_list_rate;
        public GList m_list_pet;
        public GGroup m_n13;
        public const string URL = "ui://v22o2wamycl76";

        public static UI_PotTipSkin CreateInstance()
        {
            return (UI_PotTipSkin)UIPackage.CreateComponet("Shop", "PotTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n5 = (GImage)GetChildAt(2);
            m_n8 = (GImage)GetChildAt(3);
            m_n7 = (GTextField)GetChildAt(4);
            m_n3 = (GTextField)GetChildAt(5);
            m_n10 = (GTextField)GetChildAt(6);
            m_txt_desc = (GLabel)GetChildComAt(7);
            m_list_rate = (GList)GetChildComAt(8);
            m_list_pet = (GList)GetChildComAt(9);
            m_n13 = (GGroup)GetChildAt(10);
        }
    }
}