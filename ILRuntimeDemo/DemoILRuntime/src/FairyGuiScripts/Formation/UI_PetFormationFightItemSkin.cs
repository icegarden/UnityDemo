/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Formation
{
    public partial class UI_PetFormationFightItemSkin : GButton
    {
        public GLoader m_icon;
        public UI_PetFormationItemSkin m_headItem;
        public const string URL = "ui://6c5g9rs5pav81e";

        public static UI_PetFormationFightItemSkin CreateInstance()
        {
            return (UI_PetFormationFightItemSkin)UIPackage.CreateComponet("Formation", "PetFormationFightItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_icon = (GLoader)GetChildAt(0);
            m_headItem = (UI_PetFormationItemSkin)GetChildComAt(1);
        }
    }
}