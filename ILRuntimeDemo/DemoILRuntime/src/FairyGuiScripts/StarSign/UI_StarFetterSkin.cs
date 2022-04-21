/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarFetterSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GImage m_n3;
        public GImage m_n6;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_level;
        public GList m_list_pet;
        public GList m_list_item;
        public const string URL = "ui://xplmw3njho4vv";

        public static UI_StarFetterSkin CreateInstance()
        {
            return (UI_StarFetterSkin)UIPackage.CreateComponet("StarSign", "StarFetterSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n6 = (GImage)GetChildAt(3);
            m_txt_tip1 = (GTextField)GetChildAt(4);
            m_txt_tip2 = (GTextField)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_list_pet = (GList)GetChildComAt(7);
            m_list_item = (GList)GetChildComAt(8);
        }
    }
}