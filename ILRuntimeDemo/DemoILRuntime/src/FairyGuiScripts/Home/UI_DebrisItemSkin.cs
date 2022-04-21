/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_DebrisItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public const string URL = "ui://wua6gzxlikzm28";

        public static UI_DebrisItemSkin CreateInstance()
        {
            return (UI_DebrisItemSkin)UIPackage.CreateComponet("Home", "DebrisItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
        }
    }
}