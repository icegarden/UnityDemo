/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignRunningSkin : GComponent
    {
        public GLoader m_img_bg;
        public const string URL = "ui://e8jsnjd3s3fi23";

        public static UI_AssignRunningSkin CreateInstance()
        {
            return (UI_AssignRunningSkin)UIPackage.CreateComponet("Assign", "AssignRunningSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
        }
    }
}