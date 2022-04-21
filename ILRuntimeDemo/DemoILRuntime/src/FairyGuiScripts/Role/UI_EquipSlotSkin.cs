/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_EquipSlotSkin : GComponent
    {
        public Controller m_state;
        public GComponent m_item;
        public GImage m_n0;
        public GLoader m_img_part;
        public GImage m_img_lock;
        public GTextField m_txt_level;
        public const string URL = "ui://edfpwlj6pcjuy";

        public static UI_EquipSlotSkin CreateInstance()
        {
            return (UI_EquipSlotSkin)UIPackage.CreateComponet("Role", "EquipSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_n0 = (GImage)GetChildAt(1);
            m_img_part = (GLoader)GetChildAt(2);
            m_img_lock = (GImage)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
        }
    }
}