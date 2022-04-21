/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Pet
{
    public partial class UI_PetEvolutionSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n59;
        public GImage m_n60;
        public GImage m_n61;
        public GImage m_n63;
        public GImage m_n64;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GLoader m_img_curQuality;
        public GLoader m_img_nextQuality;
        public GComponent m_curHead;
        public GComponent m_nextHead;
        public GList m_list_attr;
        public GList m_list_cost;
        public GButton m_btn_evolution;
        public const string URL = "ui://em095moert0bf";

        public static UI_PetEvolutionSkin CreateInstance()
        {
            return (UI_PetEvolutionSkin)UIPackage.CreateComponet("Pet", "PetEvolutionSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n59 = (GImage)GetChildAt(1);
            m_n60 = (GImage)GetChildAt(2);
            m_n61 = (GImage)GetChildAt(3);
            m_n63 = (GImage)GetChildAt(4);
            m_n64 = (GImage)GetChildAt(5);
            m_txt_tip2 = (GTextField)GetChildAt(6);
            m_txt_tip3 = (GTextField)GetChildAt(7);
            m_img_curQuality = (GLoader)GetChildAt(8);
            m_img_nextQuality = (GLoader)GetChildAt(9);
            m_curHead = (GComponent)GetChildComAt(10);
            m_nextHead = (GComponent)GetChildComAt(11);
            m_list_attr = (GList)GetChildComAt(12);
            m_list_cost = (GList)GetChildComAt(13);
            m_btn_evolution = (GButton)GetChildComAt(14);
        }
    }
}