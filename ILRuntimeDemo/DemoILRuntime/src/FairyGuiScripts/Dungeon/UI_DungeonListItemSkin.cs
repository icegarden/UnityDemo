/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonListItemSkin : GComponent
    {
        public Controller m_itemstate;
        public GLoader m_img_banner;
        public GImage m_n3;
        public GImage m_n4;
        public UI_Progress m_btn_progress;
        public GButton m_btn_close;
        public GButton m_btn_explore;
        public GButton m_btn_continue;
        public UI_Exploreing m_btn_exploring;
        public UI_unlock m_btn_lock;
        public GTextField m_tf_name;
        public const string URL = "ui://uwx2vhvshioo16";

        public static UI_DungeonListItemSkin CreateInstance()
        {
            return (UI_DungeonListItemSkin)UIPackage.CreateComponet("Dungeon", "DungeonListItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_itemstate = GetControllerAt(0);
            m_img_banner = (GLoader)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n4 = (GImage)GetChildAt(2);
            m_btn_progress = (UI_Progress)GetChildComAt(3);
            m_btn_close = (GButton)GetChildComAt(4);
            m_btn_explore = (GButton)GetChildComAt(5);
            m_btn_continue = (GButton)GetChildComAt(6);
            m_btn_exploring = (UI_Exploreing)GetChildComAt(7);
            m_btn_lock = (UI_unlock)GetChildComAt(8);
            m_tf_name = (GTextField)GetChildAt(9);
        }
    }
}