/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleMapContent : GComponent
    {
        public GLoader m_img_bg;
        public UI_BattleMapNameItemSkin m_chapter_1;
        public UI_BattleMapNameItemSkin m_chapter_3;
        public UI_BattleMapNameItemSkin m_chapter_2;
        public UI_BattleMapNameItemSkin m_chapter_4;
        public UI_BattleMapNameItemSkin m_chapter_5;
        public UI_BattleMapNameItemSkin m_chapter_11;
        public UI_BattleMapNameItemSkin m_chapter_7;
        public UI_BattleMapNameItemSkin m_chapter_6;
        public UI_BattleMapNameItemSkin m_chapter_12;
        public UI_BattleMapNameItemSkin m_chapter_10;
        public UI_BattleMapNameItemSkin m_chapter_8;
        public UI_BattleMapNameItemSkin m_chapter_9;
        public UI_BattleMapNameItemSkin m_n15;
        public UI_BattleMapNameItemSkin m_n16;
        public const string URL = "ui://ej3y9mmylwv5at";

        public static UI_BattleMapContent CreateInstance()
        {
            return (UI_BattleMapContent)UIPackage.CreateComponet("Battle", "BattleMapContent");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_chapter_1 = (UI_BattleMapNameItemSkin)GetChildComAt(1);
            m_chapter_3 = (UI_BattleMapNameItemSkin)GetChildComAt(2);
            m_chapter_2 = (UI_BattleMapNameItemSkin)GetChildComAt(3);
            m_chapter_4 = (UI_BattleMapNameItemSkin)GetChildComAt(4);
            m_chapter_5 = (UI_BattleMapNameItemSkin)GetChildComAt(5);
            m_chapter_11 = (UI_BattleMapNameItemSkin)GetChildComAt(6);
            m_chapter_7 = (UI_BattleMapNameItemSkin)GetChildComAt(7);
            m_chapter_6 = (UI_BattleMapNameItemSkin)GetChildComAt(8);
            m_chapter_12 = (UI_BattleMapNameItemSkin)GetChildComAt(9);
            m_chapter_10 = (UI_BattleMapNameItemSkin)GetChildComAt(10);
            m_chapter_8 = (UI_BattleMapNameItemSkin)GetChildComAt(11);
            m_chapter_9 = (UI_BattleMapNameItemSkin)GetChildComAt(12);
            m_n15 = (UI_BattleMapNameItemSkin)GetChildComAt(13);
            m_n16 = (UI_BattleMapNameItemSkin)GetChildComAt(14);
        }
    }
}