/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleFailSkin : GComponent
    {
        public Controller m_type;
        public GImage m_n37;
        public GLoader m_img_bg;
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n30;
        public GImage m_n22;
        public GImage m_n23;
        public GButton m_btn_role;
        public GButton m_btn_equip;
        public GButton m_btn_fuwen;
        public GButton m_btn_ok;
        public GButton m_btn_data;
        public GTextField m_tf_tip1;
        public GTextField m_tf_tip2;
        public GTextField m_tf_tip3;
        public GImage m_n32;
        public GImage m_n33;
        public GImage m_n34;
        public GTextField m_txt_arenaScore;
        public GGroup m_gp_arena;
        public const string URL = "ui://ej3y9mmyivj52c";

        public static UI_BattleFailSkin CreateInstance()
        {
            return (UI_BattleFailSkin)UIPackage.CreateComponet("Battle", "BattleFailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_n37 = (GImage)GetChildAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_n0 = (GImage)GetChildAt(2);
            m_n1 = (GImage)GetChildAt(3);
            m_n2 = (GImage)GetChildAt(4);
            m_n30 = (GImage)GetChildAt(5);
            m_n22 = (GImage)GetChildAt(6);
            m_n23 = (GImage)GetChildAt(7);
            m_btn_role = (GButton)GetChildComAt(8);
            m_btn_equip = (GButton)GetChildComAt(9);
            m_btn_fuwen = (GButton)GetChildComAt(10);
            m_btn_ok = (GButton)GetChildComAt(11);
            m_btn_data = (GButton)GetChildComAt(12);
            m_tf_tip1 = (GTextField)GetChildAt(13);
            m_tf_tip2 = (GTextField)GetChildAt(14);
            m_tf_tip3 = (GTextField)GetChildAt(15);
            m_n32 = (GImage)GetChildAt(16);
            m_n33 = (GImage)GetChildAt(17);
            m_n34 = (GImage)GetChildAt(18);
            m_txt_arenaScore = (GTextField)GetChildAt(19);
            m_gp_arena = (GGroup)GetChildAt(20);
        }
    }
}