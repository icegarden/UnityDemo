/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_InvitationBossWinSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n12;
        public GImage m_img_complete;
        public GRichTextField m_txt_desc;
        public GTextField m_txt_level;
        public GButton m_btn_ok;
        public GButton m_btn_data;
        public const string URL = "ui://etkvbnyek73kz";

        public static UI_InvitationBossWinSkin CreateInstance()
        {
            return (UI_InvitationBossWinSkin)UIPackage.CreateComponet("Boss", "InvitationBossWinSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n12 = (GImage)GetChildAt(4);
            m_img_complete = (GImage)GetChildAt(5);
            m_txt_desc = (GRichTextField)GetChildAt(6);
            m_txt_level = (GTextField)GetChildAt(7);
            m_btn_ok = (GButton)GetChildComAt(8);
            m_btn_data = (GButton)GetChildComAt(9);
        }
    }
}