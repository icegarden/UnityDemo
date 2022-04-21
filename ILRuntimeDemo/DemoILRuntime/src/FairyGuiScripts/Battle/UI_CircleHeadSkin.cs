/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_CircleHeadSkin : GComponent
    {
        public GImage m_n0;
        public GLoader m_img_head;
        public GImage m_n1;
        public GGraph m_head_mask;
        public const string URL = "ui://ej3y9mmylwv5b2";

        public static UI_CircleHeadSkin CreateInstance()
        {
            return (UI_CircleHeadSkin)UIPackage.CreateComponet("Battle", "CircleHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_head_mask = (GGraph)GetChildAt(3);
        }
    }
}