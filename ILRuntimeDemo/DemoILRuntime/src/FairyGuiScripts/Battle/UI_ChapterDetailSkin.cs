/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_ChapterDetailSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public UI_ChatpterDescSkin m_desc;
        public GImage m_n3;
        public GImage m_n4;
        public GImage m_n5;
        public GImage m_n6;
        public GTextField m_tf_title;
        public GTextField m_tf_goldspeed;
        public GTextField m_tf_petspeed;
        public GTextField m_tf_rolespeed;
        public GImage m_n10;
        public GTextField m_tf_awardtip;
        public GTextField m_tf_awardtip2;
        public GButton m_btn_go;
        public GList m_list_item;
        public GImage m_n16;
        public GTextField m_tf_tip;
        public GGroup m_group_tip;
        public const string URL = "ui://ej3y9mmylwv5az";

        public static UI_ChapterDetailSkin CreateInstance()
        {
            return (UI_ChapterDetailSkin)UIPackage.CreateComponet("Battle", "ChapterDetailSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_desc = (UI_ChatpterDescSkin)GetChildComAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_n4 = (GImage)GetChildAt(4);
            m_n5 = (GImage)GetChildAt(5);
            m_n6 = (GImage)GetChildAt(6);
            m_tf_title = (GTextField)GetChildAt(7);
            m_tf_goldspeed = (GTextField)GetChildAt(8);
            m_tf_petspeed = (GTextField)GetChildAt(9);
            m_tf_rolespeed = (GTextField)GetChildAt(10);
            m_n10 = (GImage)GetChildAt(11);
            m_tf_awardtip = (GTextField)GetChildAt(12);
            m_tf_awardtip2 = (GTextField)GetChildAt(13);
            m_btn_go = (GButton)GetChildComAt(14);
            m_list_item = (GList)GetChildComAt(15);
            m_n16 = (GImage)GetChildAt(16);
            m_tf_tip = (GTextField)GetChildAt(17);
            m_group_tip = (GGroup)GetChildAt(18);
        }
    }
}