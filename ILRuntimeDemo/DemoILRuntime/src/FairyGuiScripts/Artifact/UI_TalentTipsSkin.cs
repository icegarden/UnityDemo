/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_TalentTipsSkin : GComponent
    {
        public Controller m_state;
        public GLabel m_bg;
        public GComponent m_n29;
        public GLoader m_img_talent;
        public GLoader m_img_bg;
        public GLoader m_img_type;
        public GTextField m_txt_full;
        public GTextField m_txt_level;
        public GTextField m_txt_specialUnlock;
        public GRichTextField m_txt_name;
        public GTextField m_txt_unlock;
        public GRichTextField m_txt_skillDesc;
        public GButton m_btn_upgrade;
        public GList m_list_attr;
        public GList m_list_unlock;
        public GList m_list_cost;
        public GGroup m_n26;
        public const string URL = "ui://0uxg7753oii89";

        public static UI_TalentTipsSkin CreateInstance()
        {
            return (UI_TalentTipsSkin)UIPackage.CreateComponet("Artifact", "TalentTipsSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n29 = (GComponent)GetChildComAt(1);
            m_img_talent = (GLoader)GetChildAt(2);
            m_img_bg = (GLoader)GetChildAt(3);
            m_img_type = (GLoader)GetChildAt(4);
            m_txt_full = (GTextField)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_txt_specialUnlock = (GTextField)GetChildAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
            m_txt_unlock = (GTextField)GetChildAt(9);
            m_txt_skillDesc = (GRichTextField)GetChildAt(10);
            m_btn_upgrade = (GButton)GetChildComAt(11);
            m_list_attr = (GList)GetChildComAt(12);
            m_list_unlock = (GList)GetChildComAt(13);
            m_list_cost = (GList)GetChildComAt(14);
            m_n26 = (GGroup)GetChildAt(15);
        }
    }
}