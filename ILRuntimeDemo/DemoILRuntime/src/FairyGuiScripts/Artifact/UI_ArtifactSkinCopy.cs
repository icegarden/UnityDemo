/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_ArtifactSkinCopy : GComponent
    {
        public GLoader m_bg;
        public GComponent m_con_talent;
        public GImage m_n36;
        public GImage m_img_equiped;
        public GComponent m_bg_bottom;
        public GImage m_n70;
        public GImage m_n40;
        public GImage m_n41;
        public GImage m_n42;
        public GImage m_n43;
        public GImage m_n44;
        public GImage m_n46;
        public GImage m_n49;
        public GImage m_n52;
        public GButton m_btn_pop;
        public GImage m_img_arrow;
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_tip4;
        public GTextField m_txt_totalTalent;
        public GTextField m_txt_tip5;
        public GTextField m_txt_tip6;
        public GTextField m_txt_useTalent;
        public GTextField m_txt_leftTalent;
        public GTextField m_txt_name;
        public GTextField m_txt_power;
        public GTextField m_txt_full;
        public GList m_list_item;
        public GList m_list_slot;
        public GList m_list_talentAttr;
        public GList m_list_skill;
        public GList m_list_baseAttr;
        public GList m_list_cost;
        public GButton m_btn_equip;
        public GButton m_btn_reset;
        public GButton m_btn_upgrade;
        public GGraph m_n64;
        public GGraph m_n66;
        public GGraph m_n67;
        public GGraph m_n68;
        public GGraph m_n69;
        public const string URL = "ui://0uxg7753dibi39";

        public static UI_ArtifactSkinCopy CreateInstance()
        {
            return (UI_ArtifactSkinCopy)UIPackage.CreateComponet("Artifact", "ArtifactSkinCopy");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_con_talent = (GComponent)GetChildComAt(1);
            m_n36 = (GImage)GetChildAt(2);
            m_img_equiped = (GImage)GetChildAt(3);
            m_bg_bottom = (GComponent)GetChildComAt(4);
            m_n70 = (GImage)GetChildAt(5);
            m_n40 = (GImage)GetChildAt(6);
            m_n41 = (GImage)GetChildAt(7);
            m_n42 = (GImage)GetChildAt(8);
            m_n43 = (GImage)GetChildAt(9);
            m_n44 = (GImage)GetChildAt(10);
            m_n46 = (GImage)GetChildAt(11);
            m_n49 = (GImage)GetChildAt(12);
            m_n52 = (GImage)GetChildAt(13);
            m_btn_pop = (GButton)GetChildComAt(14);
            m_img_arrow = (GImage)GetChildAt(15);
            m_txt_tip1 = (GTextField)GetChildAt(16);
            m_txt_tip2 = (GTextField)GetChildAt(17);
            m_txt_tip3 = (GTextField)GetChildAt(18);
            m_txt_tip4 = (GTextField)GetChildAt(19);
            m_txt_totalTalent = (GTextField)GetChildAt(20);
            m_txt_tip5 = (GTextField)GetChildAt(21);
            m_txt_tip6 = (GTextField)GetChildAt(22);
            m_txt_useTalent = (GTextField)GetChildAt(23);
            m_txt_leftTalent = (GTextField)GetChildAt(24);
            m_txt_name = (GTextField)GetChildAt(25);
            m_txt_power = (GTextField)GetChildAt(26);
            m_txt_full = (GTextField)GetChildAt(27);
            m_list_item = (GList)GetChildComAt(28);
            m_list_slot = (GList)GetChildComAt(29);
            m_list_talentAttr = (GList)GetChildComAt(30);
            m_list_skill = (GList)GetChildComAt(31);
            m_list_baseAttr = (GList)GetChildComAt(32);
            m_list_cost = (GList)GetChildComAt(33);
            m_btn_equip = (GButton)GetChildComAt(34);
            m_btn_reset = (GButton)GetChildComAt(35);
            m_btn_upgrade = (GButton)GetChildComAt(36);
            m_n64 = (GGraph)GetChildAt(37);
            m_n66 = (GGraph)GetChildAt(38);
            m_n67 = (GGraph)GetChildAt(39);
            m_n68 = (GGraph)GetChildAt(40);
            m_n69 = (GGraph)GetChildAt(41);
        }
    }
}