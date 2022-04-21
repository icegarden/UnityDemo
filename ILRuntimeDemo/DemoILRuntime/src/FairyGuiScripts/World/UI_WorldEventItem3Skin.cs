/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEventItem3Skin : GComponent
    {
        public UI_arrowbg m_arrow;
        public GLoader m_img_icon;
        public const string URL = "ui://63ubk2jomlxa19";

        public static UI_WorldEventItem3Skin CreateInstance()
        {
            return (UI_WorldEventItem3Skin)UIPackage.CreateComponet("World", "WorldEventItem3Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_arrow = (UI_arrowbg)GetChildComAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
        }
    }
}