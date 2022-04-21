/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Mission
{
    public partial class UI_MissionRewardItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n5;
        public GImage m_n3;
        public GImage m_n4;
        public GTextField m_txt_count;
        public const string URL = "ui://ew6i1be3sirwb";

        public static UI_MissionRewardItemSkin CreateInstance()
        {
            return (UI_MissionRewardItemSkin)UIPackage.CreateComponet("Mission", "MissionRewardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n5 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n4 = (GImage)GetChildAt(2);
            m_txt_count = (GTextField)GetChildAt(3);
        }
    }
}