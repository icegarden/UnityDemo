/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Adventure
{
    public partial class UI_AdventureSkin : GComponent
    {
        public GLoader m_bg;
        public GLoader m_bg_front;
        public UI_mainButton m_btn_arena;
        public UI_mainButton m_btn_dungeon;
        public UI_mainButton m_btn_pata;
        public UI_mainButton m_btn_boss;
        public const string URL = "ui://5cbv4acmh7460";

        public static UI_AdventureSkin CreateInstance()
        {
            return (UI_AdventureSkin)UIPackage.CreateComponet("Adventure", "AdventureSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_bg_front = (GLoader)GetChildAt(1);
            m_btn_arena = (UI_mainButton)GetChildComAt(2);
            m_btn_dungeon = (UI_mainButton)GetChildComAt(3);
            m_btn_pata = (UI_mainButton)GetChildComAt(4);
            m_btn_boss = (UI_mainButton)GetChildComAt(5);
        }
    }
}