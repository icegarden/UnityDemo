/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomListItemSkin : GComponent
    {
        public GImage m_n1;
        public GRichTextField m_txt_title;
        public GList m_list_item;
        public const string URL = "ui://rqnkl6749hynn";

        public static UI_HalidomListItemSkin CreateInstance()
        {
            return (UI_HalidomListItemSkin)UIPackage.CreateComponet("Halidom", "HalidomListItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_txt_title = (GRichTextField)GetChildAt(1);
            m_list_item = (GList)GetChildComAt(2);
        }
    }
}