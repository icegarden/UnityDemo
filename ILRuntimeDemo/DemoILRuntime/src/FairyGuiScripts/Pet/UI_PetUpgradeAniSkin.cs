/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetUpgradeAniSkin : GComponent
    {
        public Controller m_type;
        public GLoader m_bg;
        public GLoader m_img_quality;
        public GComponent m_con_avatar;
        public GLabel m_title;
        public GImage m_img_headArrow;
        public GComponent m_item_newHead;
        public GComponent m_item_oldHead;
        public GImage m_img_skillBg;
        public GButton m_img_skillIcon;
        public GTextField m_txt_skillType;
        public GComponent m_con_attr;
        public GImage m_n17;
        public GRichTextField m_txt_reward;
        public GComponent m_item_reward;
        public GGroup m_gp_reward;
        public const string URL = "ui://em095moexxxi3x";

        public static UI_PetUpgradeAniSkin CreateInstance()
        {
            return (UI_PetUpgradeAniSkin)UIPackage.CreateComponet("Pet", "PetUpgradeAniSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLoader)GetChildAt(0);
            m_img_quality = (GLoader)GetChildAt(1);
            m_con_avatar = (GComponent)GetChildComAt(2);
            m_title = (GLabel)GetChildComAt(3);
            m_img_headArrow = (GImage)GetChildAt(4);
            m_item_newHead = (GComponent)GetChildComAt(5);
            m_item_oldHead = (GComponent)GetChildComAt(6);
            m_img_skillBg = (GImage)GetChildAt(7);
            m_img_skillIcon = (GButton)GetChildComAt(8);
            m_txt_skillType = (GTextField)GetChildAt(9);
            m_con_attr = (GComponent)GetChildComAt(10);
            m_n17 = (GImage)GetChildAt(11);
            m_txt_reward = (GRichTextField)GetChildAt(12);
            m_item_reward = (GComponent)GetChildComAt(13);
            m_gp_reward = (GGroup)GetChildAt(14);
        }
    }
}