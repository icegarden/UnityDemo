/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HomeSkin : GComponent
    {
        public UI_HomeMapSkin m_view_map;
        public GImage m_n0;
        public GButton m_btn_hall;
        public GButton m_btn_guild;
        public GButton m_btn_friend;
        public GButton m_btn_back;
        public const string URL = "ui://wua6gzxlikzm0";

        public static UI_HomeSkin CreateInstance()
        {
            return (UI_HomeSkin)UIPackage.CreateComponet("Home", "HomeSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_view_map = (UI_HomeMapSkin)GetChildComAt(0);
            m_n0 = (GImage)GetChildAt(1);
            m_btn_hall = (GButton)GetChildComAt(2);
            m_btn_guild = (GButton)GetChildComAt(3);
            m_btn_friend = (GButton)GetChildComAt(4);
            m_btn_back = (GButton)GetChildComAt(5);
        }
    }
}