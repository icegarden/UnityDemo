/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace MainCity
{
    public partial class UI_RightMenuSkin : GComponent
    {
        public GButton m_btn_mission;
        public GButton m_btn_friend;
        public GButton m_btn_mail;
        public const string URL = "ui://ewnupz9msig2q";

        public static UI_RightMenuSkin CreateInstance()
        {
            return (UI_RightMenuSkin)UIPackage.CreateComponet("MainCity", "RightMenuSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_btn_mission = (GButton)GetChildComAt(0);
            m_btn_friend = (GButton)GetChildComAt(1);
            m_btn_mail = (GButton)GetChildComAt(2);
        }
    }
}