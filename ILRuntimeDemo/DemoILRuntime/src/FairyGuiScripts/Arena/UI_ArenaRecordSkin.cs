/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaRecordSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public const string URL = "ui://m8qegzmncnj3e";

        public static UI_ArenaRecordSkin CreateInstance()
        {
            return (UI_ArenaRecordSkin)UIPackage.CreateComponet("Arena", "ArenaRecordSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
        }
    }
}