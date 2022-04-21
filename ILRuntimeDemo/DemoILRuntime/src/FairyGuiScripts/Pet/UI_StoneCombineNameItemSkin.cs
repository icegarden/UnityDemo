/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_StoneCombineNameItemSkin : GComponent
    {
        public GImage m_n1;
        public GTextField m_txt_name;
        public const string URL = "ui://em095moert0b18";

        public static UI_StoneCombineNameItemSkin CreateInstance()
        {
            return (UI_StoneCombineNameItemSkin)UIPackage.CreateComponet("Pet", "StoneCombineNameItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_txt_name = (GTextField)GetChildAt(1);
        }
    }
}