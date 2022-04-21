/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerHeadHP2Skin : GComponent
    {
        public UI_FightHeadSkin m_head;
        public UI_CommonBarSkin m_pb_hp;
        public const string URL = "ui://0qeyzr63sig26b";

        public static UI_PlayerHeadHP2Skin CreateInstance()
        {
            return (UI_PlayerHeadHP2Skin)UIPackage.CreateComponet("CommonComponents", "PlayerHeadHP2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_head = (UI_FightHeadSkin)GetChildComAt(0);
            m_pb_hp = (UI_CommonBarSkin)GetChildComAt(1);
        }
    }
}