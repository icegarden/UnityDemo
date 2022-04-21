/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_StoneSlotSkin : GComponent
    {
        public GLoader m_img_icon;
        public GButton m_btn_add;
        public const string URL = "ui://em095moert0b15";

        public static UI_StoneSlotSkin CreateInstance()
        {
            return (UI_StoneSlotSkin)UIPackage.CreateComponet("Pet", "StoneSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_btn_add = (GButton)GetChildComAt(1);
        }
    }
}