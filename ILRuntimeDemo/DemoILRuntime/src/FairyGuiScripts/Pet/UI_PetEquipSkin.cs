/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEquipSkin : GComponent
    {
        public GImage m_bg;
        public GList m_list_attr;
        public UI_PetUpgradeOpSkin m_com_upgrade;
        public GButton m_btn_remove;
        public GButton m_btn_equip;
        public GButton m_btn_detail;
        public UI_PetEquipSlotSkin m_equip1;
        public UI_PetEquipSlotSkin m_equip2;
        public UI_PetEquipSlotSkin m_equip3;
        public UI_PetEquipSlotSkin m_equip4;
        public UI_PetEquipSlotSkin m_equip5;
        public UI_PetEquipSlotSkin m_equip6;
        public GImage m_img_exclusive;
        public const string URL = "ui://em095moesig28q";

        public static UI_PetEquipSkin CreateInstance()
        {
            return (UI_PetEquipSkin)UIPackage.CreateComponet("Pet", "PetEquipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_list_attr = (GList)GetChildComAt(1);
            m_com_upgrade = (UI_PetUpgradeOpSkin)GetChildComAt(2);
            m_btn_remove = (GButton)GetChildComAt(3);
            m_btn_equip = (GButton)GetChildComAt(4);
            m_btn_detail = (GButton)GetChildComAt(5);
            m_equip1 = (UI_PetEquipSlotSkin)GetChildComAt(6);
            m_equip2 = (UI_PetEquipSlotSkin)GetChildComAt(7);
            m_equip3 = (UI_PetEquipSlotSkin)GetChildComAt(8);
            m_equip4 = (UI_PetEquipSlotSkin)GetChildComAt(9);
            m_equip5 = (UI_PetEquipSlotSkin)GetChildComAt(10);
            m_equip6 = (UI_PetEquipSlotSkin)GetChildComAt(11);
            m_img_exclusive = (GImage)GetChildAt(12);
        }
    }
}