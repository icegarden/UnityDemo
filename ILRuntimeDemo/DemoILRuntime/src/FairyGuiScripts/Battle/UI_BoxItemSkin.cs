/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BoxItemSkin : GComponent
    {
        public GLoader m_icon;
        public const string URL = "ui://ej3y9mmyk73kam";

        public static UI_BoxItemSkin CreateInstance()
        {
            return (UI_BoxItemSkin)UIPackage.CreateComponet("Battle", "BoxItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
        }
    }
}