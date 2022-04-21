/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace GuildReward
{
    public partial class UI_GuildRewardLevelItemSkin : GComponent
    {
        public Controller m_control;
        public GImage m_n6;
        public GImage m_n12;
        public GImage m_n7;
        public GTextField m_txt_msg1;
        public GTextField m_txt_msg2;
        public GTextField m_txt_msg3;
        public GTextField m_txt_msg0;
        public const string URL = "ui://l0x7u1wbx7ia11";

        public static UI_GuildRewardLevelItemSkin CreateInstance()
        {
            return (UI_GuildRewardLevelItemSkin)UIPackage.CreateComponet("GuildReward", "GuildRewardLevelItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_control = GetControllerAt(0);
            m_n6 = (GImage)GetChildAt(0);
            m_n12 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_txt_msg1 = (GTextField)GetChildAt(3);
            m_txt_msg2 = (GTextField)GetChildAt(4);
            m_txt_msg3 = (GTextField)GetChildAt(5);
            m_txt_msg0 = (GTextField)GetChildAt(6);
        }
    }
}