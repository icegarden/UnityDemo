/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ChannelItemSkin : GComponent
    {
        public GImage m_n8;
        public GImage m_n9;
        public GImage m_n7;
        public GLoader m_img_icon;
        public GImage m_n11;
        public GTextField m_txt_name;
        public GButton m_btn_select;
        public const string URL = "ui://e98lwrlopcju14";

        public static UI_ChannelItemSkin CreateInstance()
        {
            return (UI_ChannelItemSkin)UIPackage.CreateComponet("Bag", "ChannelItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n8 = (GImage)GetChildAt(0);
            m_n9 = (GImage)GetChildAt(1);
            m_n7 = (GImage)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_n11 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_btn_select = (GButton)GetChildComAt(6);
        }
    }
}