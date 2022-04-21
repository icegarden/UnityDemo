/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEquipSlotSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GLoader m_img_element;
        public GImage m_img_add;
        public GImage m_n7;
        public GImage m_n6;
        public GImage m_img_lock;
        public GList m_list_star;
        public const string URL = "ui://em095moesig28s";

        public static UI_PetEquipSlotSkin CreateInstance()
        {
            return (UI_PetEquipSlotSkin)UIPackage.CreateComponet("Pet", "PetEquipSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_element = (GLoader)GetChildAt(3);
            m_img_add = (GImage)GetChildAt(4);
            m_n7 = (GImage)GetChildAt(5);
            m_n6 = (GImage)GetChildAt(6);
            m_img_lock = (GImage)GetChildAt(7);
            m_list_star = (GList)GetChildComAt(8);
        }
    }
}