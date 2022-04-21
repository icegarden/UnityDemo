/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_AttrDetailSkin : GComponent
    {
        public UI_DialogBG3 m_bg;
        public GList m_list_base;
        public const string URL = "ui://0qeyzr63sc3q1c";

        public static UI_AttrDetailSkin CreateInstance()
        {
            return (UI_AttrDetailSkin)UIPackage.CreateComponet("CommonComponents", "AttrDetailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (UI_DialogBG3)GetChildComAt(0);
            m_list_base = (GList)GetChildComAt(1);
        }
    }
}