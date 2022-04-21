/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_InvitationBossTaskSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public GTextField m_txt_tip;
        public const string URL = "ui://etkvbnyek73kv";

        public static UI_InvitationBossTaskSkin CreateInstance()
        {
            return (UI_InvitationBossTaskSkin)UIPackage.CreateComponet("Boss", "InvitationBossTaskSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
        }
    }
}