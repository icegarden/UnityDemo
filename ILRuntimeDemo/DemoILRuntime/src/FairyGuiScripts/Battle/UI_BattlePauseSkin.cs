/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattlePauseSkin : GComponent
    {
        public GButton m_btn_goon;
        public GButton m_btn_exit;
        public const string URL = "ui://ej3y9mmyg55waj";

        public static UI_BattlePauseSkin CreateInstance()
        {
            return (UI_BattlePauseSkin)UIPackage.CreateComponet("Battle", "BattlePauseSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_btn_goon = (GButton)GetChildComAt(0);
            m_btn_exit = (GButton)GetChildComAt(1);
        }
    }
}