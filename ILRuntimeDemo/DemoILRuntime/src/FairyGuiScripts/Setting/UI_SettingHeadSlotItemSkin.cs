/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Setting
{
    public partial class UI_SettingHeadSlotItemSkin : GButton
    {
        public Controller m_state;
        public Controller m_button;
        public GLoader m_img_slot;
        public GGraph m_n8;
        public GImage m_n4;
        public GImage m_n5;
        public GImage m_n9;
        public GTextField m_txt_using;
        public const string URL = "ui://wi3k1s54j3xsv";

        public static UI_SettingHeadSlotItemSkin CreateInstance()
        {
            return (UI_SettingHeadSlotItemSkin)UIPackage.CreateComponet("Setting", "SettingHeadSlotItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_button = GetControllerAt(1);
            m_img_slot = (GLoader)GetChildAt(0);
            m_n8 = (GGraph)GetChildAt(1);
            m_n4 = (GImage)GetChildAt(2);
            m_n5 = (GImage)GetChildAt(3);
            m_n9 = (GImage)GetChildAt(4);
            m_txt_using = (GTextField)GetChildAt(5);
        }
    }
}