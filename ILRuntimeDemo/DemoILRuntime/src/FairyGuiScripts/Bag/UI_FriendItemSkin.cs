/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_FriendItemSkin : GComponent
    {
        public GImage m_n11;
        public GImage m_n12;
        public GImage m_n10;
        public GLoader m_img_icon;
        public GImage m_n15;
        public GTextField m_txt_name;
        public GTextField m_txt_online;
        public GTextField m_txt_power;
        public GButton m_btn_select;
        public const string URL = "ui://e98lwrlopcju13";

        public static UI_FriendItemSkin CreateInstance()
        {
            return (UI_FriendItemSkin)UIPackage.CreateComponet("Bag", "FriendItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n11 = (GImage)GetChildAt(0);
            m_n12 = (GImage)GetChildAt(1);
            m_n10 = (GImage)GetChildAt(2);
            m_img_icon = (GLoader)GetChildAt(3);
            m_n15 = (GImage)GetChildAt(4);
            m_txt_name = (GTextField)GetChildAt(5);
            m_txt_online = (GTextField)GetChildAt(6);
            m_txt_power = (GTextField)GetChildAt(7);
            m_btn_select = (GButton)GetChildComAt(8);
        }
    }
}