/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_center;
        public UI_WorldCityEntrySkin m_entry_1;
        public UI_WorldCityEntrySkin m_entry_2;
        public UI_WorldCityEntrySkin m_entry_3;
        public UI_WorldCityEntrySkin m_entry_4;
        public UI_WorldCityEntrySkin m_entry_5;
        public UI_WorldCityEntrySkin m_entry_6;
        public UI_WorldCityEntrySkin m_entry_7;
        public const string URL = "ui://63ubk2jodibi0";

        public static UI_WorldSkin CreateInstance()
        {
            return (UI_WorldSkin)UIPackage.CreateComponet("World", "WorldSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_center = (GLoader)GetChildAt(1);
            m_entry_1 = (UI_WorldCityEntrySkin)GetChildComAt(2);
            m_entry_2 = (UI_WorldCityEntrySkin)GetChildComAt(3);
            m_entry_3 = (UI_WorldCityEntrySkin)GetChildComAt(4);
            m_entry_4 = (UI_WorldCityEntrySkin)GetChildComAt(5);
            m_entry_5 = (UI_WorldCityEntrySkin)GetChildComAt(6);
            m_entry_6 = (UI_WorldCityEntrySkin)GetChildComAt(7);
            m_entry_7 = (UI_WorldCityEntrySkin)GetChildComAt(8);
        }
    }
}