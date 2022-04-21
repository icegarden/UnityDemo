/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingPlayerHeadSkin : GComponent
    {
        public Controller m_tab;
        public GLabel m_bg;
        public GImage m_n6;
        public GImage m_n8;
        public GLoader m_img_head;
        public GImage m_n10;
        public GLoader m_img_slot;
        public GTextField m_txt_headName;
        public GTextField m_txt_slotName;
        public GList m_list_head;
        public GList m_list_slot;
        public GButton m_btn_head;
        public GButton m_btn_slot;
        public GButton m_btn_change;
        public const string URL = "ui://wi3k1s54j3xsr";

        public static UI_SettingPlayerHeadSkin CreateInstance()
        {
            return (UI_SettingPlayerHeadSkin)UIPackage.CreateComponet("Setting", "SettingPlayerHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_bg = (GLabel)GetChildComAt(0);
            m_n6 = (GImage)GetChildAt(1);
            m_n8 = (GImage)GetChildAt(2);
            m_img_head = (GLoader)GetChildAt(3);
            m_n10 = (GImage)GetChildAt(4);
            m_img_slot = (GLoader)GetChildAt(5);
            m_txt_headName = (GTextField)GetChildAt(6);
            m_txt_slotName = (GTextField)GetChildAt(7);
            m_list_head = (GList)GetChildComAt(8);
            m_list_slot = (GList)GetChildComAt(9);
            m_btn_head = (GButton)GetChildComAt(10);
            m_btn_slot = (GButton)GetChildComAt(11);
            m_btn_change = (GButton)GetChildComAt(12);
        }
    }
}