/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Boss
{
    public partial class UI_KongMoBossWinSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n1;
        public GImage m_n2;
        public GImage m_n3;
        public GImage m_img_new;
        public GLoader m_img_box;
        public GList m_list_item;
        public GButton m_btn_ok;
        public GProgressBar m_pb_damage;
        public GRichTextField m_txt_desc;
        public GButton m_btn_data;
        public const string URL = "ui://etkvbnyek73ks";

        public static UI_KongMoBossWinSkin CreateInstance()
        {
            return (UI_KongMoBossWinSkin)UIPackage.CreateComponet("Boss", "KongMoBossWinSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n1 = (GImage)GetChildAt(1);
            m_n2 = (GImage)GetChildAt(2);
            m_n3 = (GImage)GetChildAt(3);
            m_img_new = (GImage)GetChildAt(4);
            m_img_box = (GLoader)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
            m_btn_ok = (GButton)GetChildComAt(7);
            m_pb_damage = (GProgressBar)GetChildComAt(8);
            m_txt_desc = (GRichTextField)GetChildAt(9);
            m_btn_data = (GButton)GetChildComAt(10);
        }
    }
}