/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Library
{
    public partial class UI_LibraryItemSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_img_lock;
        public GTextField m_txt_lock;
        public GTextField m_txt_name;
        public GRichTextField m_txt_desc;
        public const string URL = "ui://vkxqgoc5ycl75";

        public static UI_LibraryItemSkin CreateInstance()
        {
            return (UI_LibraryItemSkin)UIPackage.CreateComponet("Library", "LibraryItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_img_lock = (GImage)GetChildAt(1);
            m_txt_lock = (GTextField)GetChildAt(2);
            m_txt_name = (GTextField)GetChildAt(3);
            m_txt_desc = (GRichTextField)GetChildAt(4);
        }
    }
}