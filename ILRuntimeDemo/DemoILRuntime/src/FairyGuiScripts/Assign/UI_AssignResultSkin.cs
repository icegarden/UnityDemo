/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignResultSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_n10;
        public GImage m_n8;
        public GTextField m_txt_exp;
        public GList m_list_item;
        public GButton m_btn_ok;
        public const string URL = "ui://e8jsnjd3s3fi27";

        public static UI_AssignResultSkin CreateInstance()
        {
            return (UI_AssignResultSkin)UIPackage.CreateComponet("Assign", "AssignResultSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n10 = (GImage)GetChildAt(4);
            m_n8 = (GImage)GetChildAt(5);
            m_txt_exp = (GTextField)GetChildAt(6);
            m_list_item = (GList)GetChildComAt(7);
            m_btn_ok = (GButton)GetChildComAt(8);
        }
    }
}