/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarSignRewardItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GTextField m_txt_level;
        public GList m_list_reward;
        public GButton m_btn_take;
        public GImage m_img_complete;
        public const string URL = "ui://xplmw3njho4v10";

        public static UI_StarSignRewardItemSkin CreateInstance()
        {
            return (UI_StarSignRewardItemSkin)UIPackage.CreateComponet("StarSign", "StarSignRewardItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_txt_level = (GTextField)GetChildAt(1);
            m_list_reward = (GList)GetChildComAt(2);
            m_btn_take = (GButton)GetChildComAt(3);
            m_img_complete = (GImage)GetChildAt(4);
        }
    }
}