/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEquipTipSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_n4;
        public GImage m_n24;
        public GTextField m_txt_title;
        public GTextField m_txt_weaponTitle;
        public GTextField m_txt_armorTitle;
        public GTextField m_txt_weapon;
        public GTextField m_txt_armor;
        public GLoader m_img_weapon;
        public GLoader m_img_armor;
        public const string URL = "ui://em095moes3fia8";

        public static UI_PetEquipTipSkin CreateInstance()
        {
            return (UI_PetEquipTipSkin)UIPackage.CreateComponet("Pet", "PetEquipTipSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_n4 = (GImage)GetChildAt(1);
            m_n24 = (GImage)GetChildAt(2);
            m_txt_title = (GTextField)GetChildAt(3);
            m_txt_weaponTitle = (GTextField)GetChildAt(4);
            m_txt_armorTitle = (GTextField)GetChildAt(5);
            m_txt_weapon = (GTextField)GetChildAt(6);
            m_txt_armor = (GTextField)GetChildAt(7);
            m_img_weapon = (GLoader)GetChildAt(8);
            m_img_armor = (GLoader)GetChildAt(9);
        }
    }
}