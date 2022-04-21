/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneSkin : GComponent
    {
        public GTextField m_txt_tip1;
        public GTextField m_txt_tip2;
        public GList m_list_attr;
        public GList m_list_combine;
        public GButton m_btn_remove;
        public GButton m_btn_recommend;
        public UI_PetStoneSlotSkin m_slot0;
        public UI_PetStoneSlotSkin m_slot1;
        public UI_PetStoneSlotSkin m_slot2;
        public UI_PetStoneSlotSkin m_slot3;
        public UI_PetStoneSlotSkin m_slot4;
        public UI_PetStoneSlotSkin m_slot5;
        public UI_PetStoneSlotSkin m_slot6;
        public UI_PetStoneSlotSkin m_slot7;
        public const string URL = "ui://em095moert0bh";

        public static UI_PetStoneSkin CreateInstance()
        {
            return (UI_PetStoneSkin)UIPackage.CreateComponet("Pet", "PetStoneSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_txt_tip1 = (GTextField)GetChildAt(0);
            m_txt_tip2 = (GTextField)GetChildAt(1);
            m_list_attr = (GList)GetChildComAt(2);
            m_list_combine = (GList)GetChildComAt(3);
            m_btn_remove = (GButton)GetChildComAt(4);
            m_btn_recommend = (GButton)GetChildComAt(5);
            m_slot0 = (UI_PetStoneSlotSkin)GetChildComAt(6);
            m_slot1 = (UI_PetStoneSlotSkin)GetChildComAt(7);
            m_slot2 = (UI_PetStoneSlotSkin)GetChildComAt(8);
            m_slot3 = (UI_PetStoneSlotSkin)GetChildComAt(9);
            m_slot4 = (UI_PetStoneSlotSkin)GetChildComAt(10);
            m_slot5 = (UI_PetStoneSlotSkin)GetChildComAt(11);
            m_slot6 = (UI_PetStoneSlotSkin)GetChildComAt(12);
            m_slot7 = (UI_PetStoneSlotSkin)GetChildComAt(13);
        }
    }
}