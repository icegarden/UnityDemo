/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CommonCmb_popup : GComponent
    {
        public GImage m_n0;
        public GList m_list;
        public const string URL = "ui://0qeyzr63rb8827";

        public static UI_CommonCmb_popup CreateInstance()
        {
            return (UI_CommonCmb_popup)UIPackage.CreateComponet("CommonComponents", "CommonCmb_popup");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_list = (GList)GetChildComAt(1);
        }
    }
}