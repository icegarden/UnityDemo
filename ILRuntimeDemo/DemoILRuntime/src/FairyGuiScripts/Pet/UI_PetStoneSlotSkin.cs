/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetStoneSlotSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n8;
        public GLoader m_img_quality;
        public GLoader m_img_icon;
        public GImage m_n3;
        public const string URL = "ui://em095moert0bi";

        public static UI_PetStoneSlotSkin CreateInstance()
        {
            return (UI_PetStoneSlotSkin)UIPackage.CreateComponet("Pet", "PetStoneSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n8 = (GImage)GetChildAt(0);
            m_img_quality = (GLoader)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
        }
    }
}