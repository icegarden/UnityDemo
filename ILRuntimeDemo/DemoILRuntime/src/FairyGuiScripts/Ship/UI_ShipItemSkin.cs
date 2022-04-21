/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public const string URL = "ui://6uax1a6mmlxa8";

        public static UI_ShipItemSkin CreateInstance()
        {
            return (UI_ShipItemSkin)UIPackage.CreateComponet("Ship", "ShipItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
        }
    }
}