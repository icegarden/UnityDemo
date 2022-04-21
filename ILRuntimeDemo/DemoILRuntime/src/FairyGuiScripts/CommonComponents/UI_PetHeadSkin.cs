/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PetHeadSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GLoader m_img_element;
        public GLoader m_img_elevel;
        public GList m_list_star;
        public GTextField m_txt_level;
        public GImage m_img_lock;
        public GImage m_n17;
        public GImage m_n15;
        public GTextField m_txt_fight;
        public const string URL = "ui://0qeyzr63xxxi58";

        public static UI_PetHeadSkin CreateInstance()
        {
            return (UI_PetHeadSkin)UIPackage.CreateComponet("CommonComponents", "PetHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_element = (GLoader)GetChildAt(3);
            m_img_elevel = (GLoader)GetChildAt(4);
            m_list_star = (GList)GetChildComAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_img_lock = (GImage)GetChildAt(7);
            m_n17 = (GImage)GetChildAt(8);
            m_n15 = (GImage)GetChildAt(9);
            m_txt_fight = (GTextField)GetChildAt(10);
        }
    }
}