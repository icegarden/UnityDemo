/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonInteractEventSkin : GComponent
    {
        public Controller m_type;
        public GLabel m_bg;
        public GLoader m_img_banner;
        public GImage m_n2;
        public GImage m_n4;
        public GTextField m_txt_tip;
        public GRichTextField m_txt_desc;
        public GButton m_btn;
        public GButton m_btn_left;
        public GButton m_btn_right;
        public const string URL = "ui://uwx2vhvssig22o";

        public static UI_DungeonInteractEventSkin CreateInstance()
        {
            return (UI_DungeonInteractEventSkin)UIPackage.CreateComponet("Dungeon", "DungeonInteractEventSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_type = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_img_banner = (GLoader)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n4 = (GImage)GetChildAt(3);
            m_txt_tip = (GTextField)GetChildAt(4);
            m_txt_desc = (GRichTextField)GetChildAt(5);
            m_btn = (GButton)GetChildComAt(6);
            m_btn_left = (GButton)GetChildComAt(7);
            m_btn_right = (GButton)GetChildComAt(8);
        }
    }
}