/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetNatureItemSkin : GComponent
    {
        public GImage m_n5;
        public GLoader m_img_icon;
        public GRichTextField m_txt_name;
        public GRichTextField m_txt_value;
        public const string URL = "ui://em095moert0bm";

        public static UI_PetNatureItemSkin CreateInstance()
        {
            return (UI_PetNatureItemSkin)UIPackage.CreateComponet("Pet", "PetNatureItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n5 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_txt_name = (GRichTextField)GetChildAt(2);
            m_txt_value = (GRichTextField)GetChildAt(3);
        }
    }
}