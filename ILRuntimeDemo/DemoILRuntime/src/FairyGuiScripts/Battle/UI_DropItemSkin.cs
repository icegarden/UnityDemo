/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_DropItemSkin : GComponent
    {
        public GImage m_n0;
        public GTextField m_tf_name;
        public GLoader m_img_item;
        public const string URL = "ui://ej3y9mmyvmpc2t";

        public static UI_DropItemSkin CreateInstance()
        {
            return (UI_DropItemSkin)UIPackage.CreateComponet("Battle", "DropItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_tf_name = (GTextField)GetChildAt(1);
            m_img_item = (GLoader)GetChildAt(2);
        }
    }
}