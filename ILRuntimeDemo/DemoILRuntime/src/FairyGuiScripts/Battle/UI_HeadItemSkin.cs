/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_HeadItemSkin : GComponent
    {
        public GImage m_n3;
        public GButton m_img_head;
        public GImage m_n7;
        public UI_HeadNuqiBar m_nuqiBar;
        public const string URL = "ui://ej3y9mmyivj51w";

        public static UI_HeadItemSkin CreateInstance()
        {
            return (UI_HeadItemSkin)UIPackage.CreateComponet("Battle", "HeadItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n3 = (GImage)GetChildAt(0);
            m_img_head = (GButton)GetChildComAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_nuqiBar = (UI_HeadNuqiBar)GetChildComAt(3);
        }
    }
}