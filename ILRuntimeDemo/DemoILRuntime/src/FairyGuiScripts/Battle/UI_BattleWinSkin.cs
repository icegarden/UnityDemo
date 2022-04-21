/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleWinSkin : GComponent
    {
        public Controller m_type;
        public GImage m_n19;
        public GImage m_n3;
        public GImage m_n2;
        public GImage m_n1;
        public GList m_list_item;
        public GButton m_btn_data;
        public GButton m_btn_ok;
        public GButton m_btn_continue;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n16;
        public GTextField m_txt_arenaScore;
        public GGroup m_gp_arena;
        public const string URL = "ui://ej3y9mmyivj526";

        public static UI_BattleWinSkin CreateInstance()
        {
            return (UI_BattleWinSkin)UIPackage.CreateComponet("Battle", "BattleWinSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_n19 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n1 = (GImage)GetChildAt(3);
            m_list_item = (GList)GetChildComAt(4);
            m_btn_data = (GButton)GetChildComAt(5);
            m_btn_ok = (GButton)GetChildComAt(6);
            m_btn_continue = (GButton)GetChildComAt(7);
            m_n14 = (GImage)GetChildAt(8);
            m_n15 = (GImage)GetChildAt(9);
            m_n16 = (GImage)GetChildAt(10);
            m_txt_arenaScore = (GTextField)GetChildAt(11);
            m_gp_arena = (GGroup)GetChildAt(12);
        }
    }
}