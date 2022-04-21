/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerHeadNameSkin : GComponent
    {
        public UI_PlayerHeadSkin m_head;
        public GTextField m_txt_name;
        public const string URL = "ui://0qeyzr63ho4v6d";

        public static UI_PlayerHeadNameSkin CreateInstance()
        {
            return (UI_PlayerHeadNameSkin)UIPackage.CreateComponet("CommonComponents", "PlayerHeadNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_head = (UI_PlayerHeadSkin)GetChildComAt(0);
            m_txt_name = (GTextField)GetChildAt(1);
        }
    }
}