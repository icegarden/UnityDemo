/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Dungeon
{
    public partial class UI_DungeonSceneSkin : GComponent
    {
        public GLoader m_img_bg;
        public GButton m_btn_back;
        public GButton m_btn_bag;
        public GButton m_btn_log;
        public GImage m_n4;
        public GImage m_bar;
        public GImage m_img_barBg;
        public GImage m_n7;
        public GImage m_n8;
        public GImage m_n9;
        public GImage m_n10;
        public GImage m_n11;
        public GTextField m_tf_name;
        public GTextField m_tf_layer;
        public GTextField m_tf_time;
        public GTextField m_tf_progress;
        public GTextField m_tf_pos;
        public GTextField m_tf_desc;
        public GTextField m_tf_bugi;
        public GTextField m_tf_bugitip;
        public const string URL = "ui://uwx2vhvshioo1e";

        public static UI_DungeonSceneSkin CreateInstance()
        {
            return (UI_DungeonSceneSkin)UIPackage.CreateComponet("Dungeon", "DungeonSceneSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_btn_back = (GButton)GetChildComAt(1);
            m_btn_bag = (GButton)GetChildComAt(2);
            m_btn_log = (GButton)GetChildComAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_bar = (GImage)GetChildAt(5);
            m_img_barBg = (GImage)GetChildAt(6);
            m_n7 = (GImage)GetChildAt(7);
            m_n8 = (GImage)GetChildAt(8);
            m_n9 = (GImage)GetChildAt(9);
            m_n10 = (GImage)GetChildAt(10);
            m_n11 = (GImage)GetChildAt(11);
            m_tf_name = (GTextField)GetChildAt(12);
            m_tf_layer = (GTextField)GetChildAt(13);
            m_tf_time = (GTextField)GetChildAt(14);
            m_tf_progress = (GTextField)GetChildAt(15);
            m_tf_pos = (GTextField)GetChildAt(16);
            m_tf_desc = (GTextField)GetChildAt(17);
            m_tf_bugi = (GTextField)GetChildAt(18);
            m_tf_bugitip = (GTextField)GetChildAt(19);
        }
    }
}