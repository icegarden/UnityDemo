/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainUI
{
    public partial class UI_TopRoleInfoSkin : GComponent
    {
        public UI_ExpBarSkin m_pb_exp;
        public GLoader m_img_bg;
        public GImage m_n53;
        public GLoader m_img_head;
        public GImage m_n61;
        public GLoader m_img_slot;
        public GImage m_n57;
        public GImage m_n58;
        public GImage m_n60;
        public GImage m_n56;
        public GImage m_n55;
        public GLoader m_img_icon;
        public GTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_gold;
        public GTextField m_txt_diamond;
        public GTextField m_txt_power;
        public GButton m_btn_diamond;
        public GButton m_btn_gold;
        public const string URL = "ui://eb1q6ro1pcjud";

        public static UI_TopRoleInfoSkin CreateInstance()
        {
            return (UI_TopRoleInfoSkin)UIPackage.CreateComponet("MainUI", "TopRoleInfoSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_pb_exp = (UI_ExpBarSkin)GetChildComAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_n53 = (GImage)GetChildAt(2);
            m_img_head = (GLoader)GetChildAt(3);
            m_n61 = (GImage)GetChildAt(4);
            m_img_slot = (GLoader)GetChildAt(5);
            m_n57 = (GImage)GetChildAt(6);
            m_n58 = (GImage)GetChildAt(7);
            m_n60 = (GImage)GetChildAt(8);
            m_n56 = (GImage)GetChildAt(9);
            m_n55 = (GImage)GetChildAt(10);
            m_img_icon = (GLoader)GetChildAt(11);
            m_txt_name = (GTextField)GetChildAt(12);
            m_txt_level = (GTextField)GetChildAt(13);
            m_txt_gold = (GTextField)GetChildAt(14);
            m_txt_diamond = (GTextField)GetChildAt(15);
            m_txt_power = (GTextField)GetChildAt(16);
            m_btn_diamond = (GButton)GetChildComAt(17);
            m_btn_gold = (GButton)GetChildComAt(18);
        }
    }
}