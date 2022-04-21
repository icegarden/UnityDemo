/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_GuankaRewardSkin : GComponent
    {
        public GImage m_n20;
        public GImage m_n7;
        public GImage m_n6;
        public GImage m_n11;
        public GImage m_n12;
        public GImage m_n17;
        public GImage m_n18;
        public GList m_list_item;
        public GButton m_btn_ok;
        public GRichTextField m_txt_time;
        public const string URL = "ui://ej3y9mmypcju1i";

        public static UI_GuankaRewardSkin CreateInstance()
        {
            return (UI_GuankaRewardSkin)UIPackage.CreateComponet("Battle", "GuankaRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n20 = (GImage)GetChildAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_n6 = (GImage)GetChildAt(2);
            m_n11 = (GImage)GetChildAt(3);
            m_n12 = (GImage)GetChildAt(4);
            m_n17 = (GImage)GetChildAt(5);
            m_n18 = (GImage)GetChildAt(6);
            m_list_item = (GList)GetChildComAt(7);
            m_btn_ok = (GButton)GetChildComAt(8);
            m_txt_time = (GRichTextField)GetChildAt(9);
        }
    }
}