/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleAwardSkin : GComponent
    {
        public GLoader m_img_bg;
        public GImage m_n10;
        public GImage m_img_time;
        public GImage m_n11;
        public GImage m_n13;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n17;
        public GImage m_n21;
        public GImage m_n22;
        public GTextField m_tf_timetip;
        public GTextField m_tf_time;
        public GTextField m_tf_awardtip;
        public GTextField m_tf_itemtip;
        public GTextField m_tf_left;
        public GTextField m_tf_lefttip;
        public GTextField m_tf_title;
        public GTextField m_tf_goldspeed;
        public GTextField m_tf_petspeed;
        public GTextField m_tf_rolespeed;
        public GList m_list_item;
        public GButton m_btn_quick;
        public GButton m_btn_get;
        public GComponent m_cost;
        public const string URL = "ui://ej3y9mmylwv5aq";

        public static UI_BattleAwardSkin CreateInstance()
        {
            return (UI_BattleAwardSkin)UIPackage.CreateComponet("Battle", "BattleAwardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_n10 = (GImage)GetChildAt(1);
            m_img_time = (GImage)GetChildAt(2);
            m_n11 = (GImage)GetChildAt(3);
            m_n13 = (GImage)GetChildAt(4);
            m_n14 = (GImage)GetChildAt(5);
            m_n15 = (GImage)GetChildAt(6);
            m_n17 = (GImage)GetChildAt(7);
            m_n21 = (GImage)GetChildAt(8);
            m_n22 = (GImage)GetChildAt(9);
            m_tf_timetip = (GTextField)GetChildAt(10);
            m_tf_time = (GTextField)GetChildAt(11);
            m_tf_awardtip = (GTextField)GetChildAt(12);
            m_tf_itemtip = (GTextField)GetChildAt(13);
            m_tf_left = (GTextField)GetChildAt(14);
            m_tf_lefttip = (GTextField)GetChildAt(15);
            m_tf_title = (GTextField)GetChildAt(16);
            m_tf_goldspeed = (GTextField)GetChildAt(17);
            m_tf_petspeed = (GTextField)GetChildAt(18);
            m_tf_rolespeed = (GTextField)GetChildAt(19);
            m_list_item = (GList)GetChildComAt(20);
            m_btn_quick = (GButton)GetChildComAt(21);
            m_btn_get = (GButton)GetChildComAt(22);
            m_cost = (GComponent)GetChildComAt(23);
        }
    }
}