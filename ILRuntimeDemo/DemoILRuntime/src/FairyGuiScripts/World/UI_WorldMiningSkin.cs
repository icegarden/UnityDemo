/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldMiningSkin : GComponent
    {
        public GLabel m_bg;
        public GList m_list_item;
        public GRichTextField m_txt_count;
        public const string URL = "ui://63ubk2jodibit";

        public static UI_WorldMiningSkin CreateInstance()
        {
            return (UI_WorldMiningSkin)UIPackage.CreateComponet("World", "WorldMiningSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_list_item = (GList)GetChildComAt(1);
            m_txt_count = (GRichTextField)GetChildAt(2);
        }
    }
}