/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarSignRewardSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n1;
        public GTextField m_txt_level;
        public GList m_list_item;
        public const string URL = "ui://xplmw3njho4vz";

        public static UI_StarSignRewardSkin CreateInstance()
        {
            return (UI_StarSignRewardSkin)UIPackage.CreateComponet("StarSign", "StarSignRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_txt_level = (GTextField)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
        }
    }
}