/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldCityMapSkin : GComponent
    {
        public GLoader m_bg;
        public GComponent m_con;
        public const string URL = "ui://63ubk2jodibix";

        public static UI_WorldCityMapSkin CreateInstance()
        {
            return (UI_WorldCityMapSkin)UIPackage.CreateComponet("World", "WorldCityMapSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_con = (GComponent)GetChildComAt(1);
        }
    }
}