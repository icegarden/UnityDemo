/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignSuccessSkin : GComponent
    {
        public GImage m_img_success;
        public GImage m_img_complete;
        public const string URL = "ui://e8jsnjd3s3fi29";

        public static UI_AssignSuccessSkin CreateInstance()
        {
            return (UI_AssignSuccessSkin)UIPackage.CreateComponet("Assign", "AssignSuccessSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_success = (GImage)GetChildAt(0);
            m_img_complete = (GImage)GetChildAt(1);
        }
    }
}