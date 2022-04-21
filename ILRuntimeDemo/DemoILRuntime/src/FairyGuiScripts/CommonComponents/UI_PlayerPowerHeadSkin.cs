/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerPowerHeadSkin : GComponent
    {
        public Controller m_state;
        public UI_PlayerHeadSkin m_head;
        public GImage m_n7;
        public GImage m_n3;
        public GImage m_n2;
        public GImage m_n5;
        public GTextField m_txt_power;
        public GTextField m_txt_selected;
        public const string URL = "ui://0qeyzr63sig233";

        public static UI_PlayerPowerHeadSkin CreateInstance()
        {
            return (UI_PlayerPowerHeadSkin)UIPackage.CreateComponet("CommonComponents", "PlayerPowerHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_head = (UI_PlayerHeadSkin)GetChildComAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_n3 = (GImage)GetChildAt(2);
            m_n2 = (GImage)GetChildAt(3);
            m_n5 = (GImage)GetChildAt(4);
            m_txt_power = (GTextField)GetChildAt(5);
            m_txt_selected = (GTextField)GetChildAt(6);
        }
    }
}