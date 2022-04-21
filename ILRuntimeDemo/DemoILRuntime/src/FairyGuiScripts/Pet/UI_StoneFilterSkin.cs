/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_StoneFilterSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n10;
        public GImage m_n7;
        public GImage m_n8;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GList m_list_black;
        public GList m_list_white;
        public GComponent m_btn_close;
        public GGroup m_n9;
        public const string URL = "ui://em095moert0b16";

        public static UI_StoneFilterSkin CreateInstance()
        {
            return (UI_StoneFilterSkin)UIPackage.CreateComponet("Pet", "StoneFilterSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n10 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n8 = (GImage)GetChildAt(3);
            m_txt_tip1 = (GTextField)GetChildAt(4);
            m_txt_tip2 = (GTextField)GetChildAt(5);
            m_list_black = (GList)GetChildComAt(6);
            m_list_white = (GList)GetChildComAt(7);
            m_btn_close = (GComponent)GetChildComAt(8);
            m_n9 = (GGroup)GetChildAt(9);
        }
    }
}