/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PetHeadNameSkin : GComponent
    {
        public UI_PetHeadSkin m_head;
        public GRichTextField m_txt_name;
        public const string URL = "ui://0qeyzr63fasi6k";

        public static UI_PetHeadNameSkin CreateInstance()
        {
            return (UI_PetHeadNameSkin)UIPackage.CreateComponet("CommonComponents", "PetHeadNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_head = (UI_PetHeadSkin)GetChildComAt(0);
            m_txt_name = (GRichTextField)GetChildAt(1);
        }
    }
}