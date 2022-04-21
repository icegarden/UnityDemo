/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetCostSlotSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public GImage m_img_anyHead;
        public GLoader m_img_slot;
        public GLoader m_img_type;
        public GTextField m_txt_elevel;
        public GRichTextField m_txt_count;
        public const string URL = "ui://em095moert0bq";

        public static UI_PetCostSlotSkin CreateInstance()
        {
            return (UI_PetCostSlotSkin)UIPackage.CreateComponet("Pet", "PetCostSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_img_anyHead = (GImage)GetChildAt(2);
            m_img_slot = (GLoader)GetChildAt(3);
            m_img_type = (GLoader)GetChildAt(4);
            m_txt_elevel = (GTextField)GetChildAt(5);
            m_txt_count = (GRichTextField)GetChildAt(6);
        }
    }
}