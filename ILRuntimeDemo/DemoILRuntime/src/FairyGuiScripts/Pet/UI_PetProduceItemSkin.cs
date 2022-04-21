/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetProduceItemSkin : GComponent
    {
        public GImage m_bg;
        public GLoader m_img_icon;
        public GTextField m_txt_count;
        public const string URL = "ui://em095moert0ba";

        public static UI_PetProduceItemSkin CreateInstance()
        {
            return (UI_PetProduceItemSkin)UIPackage.CreateComponet("Pet", "PetProduceItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_txt_count = (GTextField)GetChildAt(2);
        }
    }
}