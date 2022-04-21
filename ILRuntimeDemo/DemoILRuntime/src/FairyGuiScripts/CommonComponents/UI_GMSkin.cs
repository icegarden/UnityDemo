/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_GMSkin : GComponent
    {
        public Controller m_tab;
        public UI_DialogBG1 m_n2;
        public GImage m_n4;
        public GImage m_n7;
        public GImage m_n9;
        public GImage m_n19;
        public GTextField m_n6;
        public GTextField m_n18;
        public GTextField m_n22;
        public GTextInput m_txt_guankaID;
        public GTextInput m_txt_itemID;
        public GTextInput m_txt_input;
        public GTextInput m_txt_itemCount;
        public GList m_list_item;
        public UI_CommonBtn1Yellow m_btn_send;
        public UI_CommonBtn1Yellow m_btn_get;
        public UI_CommonTab1 m_btn_item;
        public UI_CommonTab1 m_btn_equip;
        public UI_CommonTab1 m_btn_pet;
        public UI_CommonBtn1Yellow m_btn_jump;
        public const string URL = "ui://0qeyzr63sc3qg";

        public static UI_GMSkin CreateInstance()
        {
            return (UI_GMSkin)UIPackage.CreateComponet("CommonComponents", "GMSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tab = GetControllerAt(0);
            m_n2 = (UI_DialogBG1)GetChildComAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_n9 = (GImage)GetChildAt(3);
            m_n19 = (GImage)GetChildAt(4);
            m_n6 = (GTextField)GetChildAt(5);
            m_n18 = (GTextField)GetChildAt(6);
            m_n22 = (GTextField)GetChildAt(7);
            m_txt_guankaID = (GTextInput)GetChildAt(8);
            m_txt_itemID = (GTextInput)GetChildAt(9);
            m_txt_input = (GTextInput)GetChildAt(10);
            m_txt_itemCount = (GTextInput)GetChildAt(11);
            m_list_item = (GList)GetChildComAt(12);
            m_btn_send = (UI_CommonBtn1Yellow)GetChildComAt(13);
            m_btn_get = (UI_CommonBtn1Yellow)GetChildComAt(14);
            m_btn_item = (UI_CommonTab1)GetChildComAt(15);
            m_btn_equip = (UI_CommonTab1)GetChildComAt(16);
            m_btn_pet = (UI_CommonTab1)GetChildComAt(17);
            m_btn_jump = (UI_CommonBtn1Yellow)GetChildComAt(18);
        }
    }
}