/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetHeadSelectSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GLoader m_img_type;
        public GRichTextField m_txt_name;
        public GTextField m_txt_level;
        public GTextField m_txt_elevel;
        public GImage m_n16;
        public GImage m_img_lock;
        public GImage m_n12;
        public GImage m_n13;
        public const string URL = "ui://em095moert0bs";

        public static UI_PetHeadSelectSkin CreateInstance()
        {
            return (UI_PetHeadSelectSkin)UIPackage.CreateComponet("Pet", "PetHeadSelectSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_type = (GLoader)GetChildAt(3);
            m_txt_name = (GRichTextField)GetChildAt(4);
            m_txt_level = (GTextField)GetChildAt(5);
            m_txt_elevel = (GTextField)GetChildAt(6);
            m_n16 = (GImage)GetChildAt(7);
            m_img_lock = (GImage)GetChildAt(8);
            m_n12 = (GImage)GetChildAt(9);
            m_n13 = (GImage)GetChildAt(10);
        }
    }
}