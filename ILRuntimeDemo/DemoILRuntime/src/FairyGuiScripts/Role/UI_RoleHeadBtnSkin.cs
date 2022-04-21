/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Role
{
    public partial class UI_RoleHeadBtnSkin : GButton
    {
        public Controller m_button;
        public GImage m_n0;
        public GLoader m_img_head;
        public GImage m_n1;
        public GImage m_n3;
        public const string URL = "ui://edfpwlj6dibi3j";

        public static UI_RoleHeadBtnSkin CreateInstance()
        {
            return (UI_RoleHeadBtnSkin)UIPackage.CreateComponet("Role", "RoleHeadBtnSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_n0 = (GImage)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
        }
    }
}