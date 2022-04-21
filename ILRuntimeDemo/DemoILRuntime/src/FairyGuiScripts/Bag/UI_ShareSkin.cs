/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_ShareSkin : GComponent
    {
        public GLabel m_bg;
        public GLoader m_shading;
        public GImage m_n12;
        public GImage m_n13;
        public GTextField m_txt_tip1;
        public GTextField m_txt_groupName;
        public GList m_list_channel;
        public GList m_list_friend;
        public GButton m_btn_share;
        public GButton m_btn_cancel;
        public GComponent m_btn_close;
        public const string URL = "ui://e98lwrlopcju12";

        public static UI_ShareSkin CreateInstance()
        {
            return (UI_ShareSkin)UIPackage.CreateComponet("Bag", "ShareSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_shading = (GLoader)GetChildAt(1);
            m_n12 = (GImage)GetChildAt(2);
            m_n13 = (GImage)GetChildAt(3);
            m_txt_tip1 = (GTextField)GetChildAt(4);
            m_txt_groupName = (GTextField)GetChildAt(5);
            m_list_channel = (GList)GetChildComAt(6);
            m_list_friend = (GList)GetChildComAt(7);
            m_btn_share = (GButton)GetChildComAt(8);
            m_btn_cancel = (GButton)GetChildComAt(9);
            m_btn_close = (GComponent)GetChildComAt(10);
        }
    }
}