/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_BulletinSkin : GComponent
    {
        public GLabel m_bg;
        public GLabel m_txt_content;
        public const string URL = "ui://o08pjsz8c6ya2";

        public static UI_BulletinSkin CreateInstance()
        {
            return (UI_BulletinSkin)UIPackage.CreateComponet("Login", "BulletinSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_txt_content = (GLabel)GetChildComAt(1);
        }
    }
}