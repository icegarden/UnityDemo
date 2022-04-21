/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_SelectStoneSlotSkin : GComponent
    {
        public GComponent m_item;
        public GButton m_btn_select;
        public const string URL = "ui://em095moert0b14";

        public static UI_SelectStoneSlotSkin CreateInstance()
        {
            return (UI_SelectStoneSlotSkin)UIPackage.CreateComponet("Pet", "SelectStoneSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (GComponent)GetChildComAt(0);
            m_btn_select = (GButton)GetChildComAt(1);
        }
    }
}