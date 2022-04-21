/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_PetElementItemSkin : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://etkvbnyek73ku";

        public static UI_PetElementItemSkin CreateInstance()
        {
            return (UI_PetElementItemSkin)UIPackage.CreateComponet("Boss", "PetElementItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}