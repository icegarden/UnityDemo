/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_ChapterHeadSkin : GComponent
    {
        public GImage m_n0;
        public GLoader m_img_head;
        public GImage m_n2;
        public GLoader m_img_slot;
        public GTextField m_txt_level;
        public GTextField m_txt_name;
        public const string URL = "ui://ej3y9mmylwv5b5";

        public static UI_ChapterHeadSkin CreateInstance()
        {
            return (UI_ChapterHeadSkin)UIPackage.CreateComponet("Battle", "ChapterHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_img_slot = (GLoader)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
        }
    }
}