/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldEventItem2Skin : GComponent
    {
        public GImage m_n1;
        public GLoader m_img_icon;
        public const string URL = "ui://63ubk2jomlxa18";

        public static UI_WorldEventItem2Skin CreateInstance()
        {
            return (UI_WorldEventItem2Skin)UIPackage.CreateComponet("World", "WorldEventItem2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
        }
    }
}