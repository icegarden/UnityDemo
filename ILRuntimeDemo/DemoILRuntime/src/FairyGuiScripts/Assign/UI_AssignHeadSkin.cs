/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignHeadSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n9;
        public GComponent m_head;
        public GImage m_n7;
        public GImage m_n10;
        public GTextField m_txt_working;
        public GTextField m_txt_exploring;
        public const string URL = "ui://e8jsnjd3gikd8";

        public static UI_AssignHeadSkin CreateInstance()
        {
            return (UI_AssignHeadSkin)UIPackage.CreateComponet("Assign", "AssignHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n9 = (GImage)GetChildAt(0);
            m_head = (GComponent)GetChildComAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n10 = (GImage)GetChildAt(3);
            m_txt_working = (GTextField)GetChildAt(4);
            m_txt_exploring = (GTextField)GetChildAt(5);
        }
    }
}