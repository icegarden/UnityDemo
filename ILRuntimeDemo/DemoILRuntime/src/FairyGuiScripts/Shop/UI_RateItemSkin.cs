/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Shop
{
    public partial class UI_RateItemSkin : GComponent
    {
        public GLoader m_img_icon;
        public GTextField m_txt_rate;
        public const string URL = "ui://v22o2wamycl7a";

        public static UI_RateItemSkin CreateInstance()
        {
            return (UI_RateItemSkin)UIPackage.CreateComponet("Shop", "RateItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_txt_rate = (GTextField)GetChildAt(1);
        }
    }
}