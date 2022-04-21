/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n53;
        public GImage m_n71;
        public GImage m_n48;
        public GImage m_bg_head;
        public GImage m_n81;
        public GImage m_n78;
        public GImage m_n52;
        public GImage m_box;
        public GButton m_btn_map;
        public GButton m_btn_case;
        public UI_SpeedBtn m_btn_speed;
        public GButton m_btn_chat;
        public UI_Progress_Red m_progress_red;
        public GTextField m_tf_chapterName;
        public GTextField m_tf_mapname;
        public GTextField m_tf_mapname2;
        public GTextField m_tf_time;
        public GTextField m_tf_bossTime;
        public GTextField m_txt_recommendPower;
        public GProgressBar m_pb_damage;
        public GTextField m_txt_buffCount;
        public GTextField m_txt_boxCount;
        public GTextField m_txt_damageLevel;
        public GTextField m_txt_damage;
        public GLoader m_img_box;
        public GLoader m_img_buff;
        public GList m_list_head;
        public GProgressBar m_progress_case;
        public GButton m_btn_boss;
        public GButton m_btn_autoNext;
        public GButton m_btn_hand;
        public GButton m_btn_auto;
        public GButton m_btn_pause;
        public GButton m_btn_skip;
        public GButton m_btn_cancelautoNext;
        public GButton m_btn_bag;
        public const string URL = "ui://ej3y9mmypcju0";

        public static UI_BattleSkin CreateInstance()
        {
            return (UI_BattleSkin)UIPackage.CreateComponet("Battle", "BattleSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n53 = (GImage)GetChildAt(0);
            m_n71 = (GImage)GetChildAt(1);
            m_n48 = (GImage)GetChildAt(2);
            m_bg_head = (GImage)GetChildAt(3);
            m_n81 = (GImage)GetChildAt(4);
            m_n78 = (GImage)GetChildAt(5);
            m_n52 = (GImage)GetChildAt(6);
            m_box = (GImage)GetChildAt(7);
            m_btn_map = (GButton)GetChildComAt(8);
            m_btn_case = (GButton)GetChildComAt(9);
            m_btn_speed = (UI_SpeedBtn)GetChildComAt(10);
            m_btn_chat = (GButton)GetChildComAt(11);
            m_progress_red = (UI_Progress_Red)GetChildComAt(12);
            m_tf_chapterName = (GTextField)GetChildAt(13);
            m_tf_mapname = (GTextField)GetChildAt(14);
            m_tf_mapname2 = (GTextField)GetChildAt(15);
            m_tf_time = (GTextField)GetChildAt(16);
            m_tf_bossTime = (GTextField)GetChildAt(17);
            m_txt_recommendPower = (GTextField)GetChildAt(18);
            m_pb_damage = (GProgressBar)GetChildComAt(19);
            m_txt_buffCount = (GTextField)GetChildAt(20);
            m_txt_boxCount = (GTextField)GetChildAt(21);
            m_txt_damageLevel = (GTextField)GetChildAt(22);
            m_txt_damage = (GTextField)GetChildAt(23);
            m_img_box = (GLoader)GetChildAt(24);
            m_img_buff = (GLoader)GetChildAt(25);
            m_list_head = (GList)GetChildComAt(26);
            m_progress_case = (GProgressBar)GetChildComAt(27);
            m_btn_boss = (GButton)GetChildComAt(28);
            m_btn_autoNext = (GButton)GetChildComAt(29);
            m_btn_hand = (GButton)GetChildComAt(30);
            m_btn_auto = (GButton)GetChildComAt(31);
            m_btn_pause = (GButton)GetChildComAt(32);
            m_btn_skip = (GButton)GetChildComAt(33);
            m_btn_cancelautoNext = (GButton)GetChildComAt(34);
            m_btn_bag = (GButton)GetChildComAt(35);
        }
    }
}