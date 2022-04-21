/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomValidPetSkin : GComponent
    {
        public GImage m_bg;
        public GList m_list_pet;
        public GTextField m_txt_tip;
        public const string URL = "ui://rqnkl674k73k1m";

        public static UI_HalidomValidPetSkin CreateInstance()
        {
            return (UI_HalidomValidPetSkin)UIPackage.CreateComponet("Halidom", "HalidomValidPetSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_list_pet = (GList)GetChildComAt(1);
            m_txt_tip = (GTextField)GetChildAt(2);
        }
    }
}