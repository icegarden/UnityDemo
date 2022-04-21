/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mission
{
    public partial class UI_MissionRewardTipSkin : GComponent
    {
        public GImage m_bg_tip;
        public GList m_list_reward;
        public GTextField m_txt_tip;
        public const string URL = "ui://ew6i1be3j3jin";

        public static UI_MissionRewardTipSkin CreateInstance()
        {
            return (UI_MissionRewardTipSkin)UIPackage.CreateComponet("Mission", "MissionRewardTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg_tip = (GImage)GetChildAt(0);
            m_list_reward = (GList)GetChildComAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
        }
    }
}