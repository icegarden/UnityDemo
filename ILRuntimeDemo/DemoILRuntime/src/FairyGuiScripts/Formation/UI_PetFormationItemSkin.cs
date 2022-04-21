/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Formation
{
    public partial class UI_PetFormationItemSkin : GComponent
    {
        public Controller m_state;
        public Controller m_showHP;
        public GComponent m_head;
        public GImage m_n17;
        public GImage m_img_fight;
        public GImage m_img_dead;
        public GTextField m_txt_fight;
        public GTextField m_txt_dead;
        public GProgressBar m_pb_hp;
        public const string URL = "ui://6c5g9rs5rb883q";

        public static UI_PetFormationItemSkin CreateInstance()
        {
            return (UI_PetFormationItemSkin)UIPackage.CreateComponet("Formation", "PetFormationItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_showHP = GetControllerAt(1);
            m_head = (GComponent)GetChildComAt(0);
            m_n17 = (GImage)GetChildAt(1);
            m_img_fight = (GImage)GetChildAt(2);
            m_img_dead = (GImage)GetChildAt(3);
            m_txt_fight = (GTextField)GetChildAt(4);
            m_txt_dead = (GTextField)GetChildAt(5);
            m_pb_hp = (GProgressBar)GetChildComAt(6);
        }
    }
}