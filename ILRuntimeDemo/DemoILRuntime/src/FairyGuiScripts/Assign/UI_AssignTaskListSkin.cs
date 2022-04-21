/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignTaskListSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n3;
        public GProgressBar m_pb_exp;
        public GLoader m_img_exp;
        public GList m_list_task;
        public GTextField m_txt_none;
        public const string URL = "ui://e8jsnjd3s3fi20";

        public static UI_AssignTaskListSkin CreateInstance()
        {
            return (UI_AssignTaskListSkin)UIPackage.CreateComponet("Assign", "AssignTaskListSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_pb_exp = (GProgressBar)GetChildComAt(2);
            m_img_exp = (GLoader)GetChildAt(3);
            m_list_task = (GList)GetChildComAt(4);
            m_txt_none = (GTextField)GetChildAt(5);
        }
    }
}