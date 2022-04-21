/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaDataItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GProgressBar m_pb_damage;
        public GProgressBar m_pb_defense;
        public GProgressBar m_pb_heal;
        public GRichTextField m_txt_damage;
        public GRichTextField m_txt_defense;
        public GRichTextField m_txt_heal;
        public const string URL = "ui://m8qegzmncnj3c";

        public static UI_ArenaDataItemSkin CreateInstance()
        {
            return (UI_ArenaDataItemSkin)UIPackage.CreateComponet("Arena", "ArenaDataItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_pb_damage = (GProgressBar)GetChildComAt(3);
            m_pb_defense = (GProgressBar)GetChildComAt(4);
            m_pb_heal = (GProgressBar)GetChildComAt(5);
            m_txt_damage = (GRichTextField)GetChildAt(6);
            m_txt_defense = (GRichTextField)GetChildAt(7);
            m_txt_heal = (GRichTextField)GetChildAt(8);
        }
    }
}