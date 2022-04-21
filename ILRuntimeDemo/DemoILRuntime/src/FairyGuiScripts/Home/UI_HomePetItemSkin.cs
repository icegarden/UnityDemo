/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Home
{
    public partial class UI_HomePetItemSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GImage m_n16;
        public GImage m_img_show;
        public GLoader m_img_element;
        public GTextField m_txt_show;
        public GTextField m_txt_level;
        public GTextField m_txt_elevel;
        public const string URL = "ui://wua6gzxlikzm22";

        public static UI_HomePetItemSkin CreateInstance()
        {
            return (UI_HomePetItemSkin)UIPackage.CreateComponet("Home", "HomePetItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_n16 = (GImage)GetChildAt(3);
            m_img_show = (GImage)GetChildAt(4);
            m_img_element = (GLoader)GetChildAt(5);
            m_txt_show = (GTextField)GetChildAt(6);
            m_txt_level = (GTextField)GetChildAt(7);
            m_txt_elevel = (GTextField)GetChildAt(8);
        }
    }
}