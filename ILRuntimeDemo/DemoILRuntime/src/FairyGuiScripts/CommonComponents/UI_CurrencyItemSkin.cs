/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_CurrencyItemSkin : GComponent
    {
        public GImage m_bg;
        public GLoader m_img_money;
        public GTextField m_txt_money;
        public const string URL = "ui://0qeyzr63g7def";

        public static UI_CurrencyItemSkin CreateInstance()
        {
            return (UI_CurrencyItemSkin)UIPackage.CreateComponet("CommonComponents", "CurrencyItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GImage)GetChildAt(0);
            m_img_money = (GLoader)GetChildAt(1);
            m_txt_money = (GTextField)GetChildAt(2);
        }
    }
}