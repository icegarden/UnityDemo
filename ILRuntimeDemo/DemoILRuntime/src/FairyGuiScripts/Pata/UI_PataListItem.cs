/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pata
{
    public partial class UI_PataListItem : GComponent
    {
        public GImage m_n6;
        public GList m_list_item;
        public GImage m_n8;
        public GTextField m_tf_title;
        public GButton m_btn_fight;
        public GComponent m_headItem;
        public GImage m_n10;
        public GImage m_n11;
        public GTextField m_txt_power;
        public GImage m_img_pass;
        public const string URL = "ui://29ak73mnh9kj1";

        public static UI_PataListItem CreateInstance()
        {
            return (UI_PataListItem)UIPackage.CreateComponet("Pata", "PataListItem");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n6 = (GImage)GetChildAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_n8 = (GImage)GetChildAt(2);
            m_tf_title = (GTextField)GetChildAt(3);
            m_btn_fight = (GButton)GetChildComAt(4);
            m_headItem = (GComponent)GetChildComAt(5);
            m_n10 = (GImage)GetChildAt(6);
            m_n11 = (GImage)GetChildAt(7);
            m_txt_power = (GTextField)GetChildAt(8);
            m_img_pass = (GImage)GetChildAt(9);
        }
    }
}