/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonTipsSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n4;
        public GTextField m_txt_title;
        public GTextField m_txt_desc;
        public const string URL = "ui://0qeyzr63q7xj10";

        public static UI_CommonTipsSkin CreateInstance()
        {
            return (UI_CommonTipsSkin)UIPackage.CreateComponet("CommonComponents", "CommonTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_txt_title = (GTextField)GetChildAt(2);
            m_txt_desc = (GTextField)GetChildAt(3);
        }
    }
}