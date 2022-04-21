/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Friend
{
    public partial class UI_BlockCompSkin : GComponent
    {
        public GImage m_n27;
        public GImage m_n28;
        public GTextField m_txt0;
        public GTextField m_txt_count;
        public GList m_list_member;
        public const string URL = "ui://jlg88jbimde4r";

        public static UI_BlockCompSkin CreateInstance()
        {
            return (UI_BlockCompSkin)UIPackage.CreateComponet("Friend", "BlockCompSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n27 = (GImage)GetChildAt(0);
            m_n28 = (GImage)GetChildAt(1);
            m_txt0 = (GTextField)GetChildAt(2);
            m_txt_count = (GTextField)GetChildAt(3);
            m_list_member = (GList)GetChildComAt(4);
        }
    }
}