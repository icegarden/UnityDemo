/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ComomnRewardSkin : GComponent
    {
        public GImage m_n20;
        public GImage m_n14;
        public GImage m_n15;
        public GImage m_n16;
        public GImage m_n17;
        public GList m_list_item;
        public UI_CommonBtn1Yellow m_btn_ok;
        public const string URL = "ui://0qeyzr63gl3760";

        public static UI_ComomnRewardSkin CreateInstance()
        {
            return (UI_ComomnRewardSkin)UIPackage.CreateComponet("CommonComponents", "ComomnRewardSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n20 = (GImage)GetChildAt(0);
            m_n14 = (GImage)GetChildAt(1);
            m_n15 = (GImage)GetChildAt(2);
            m_n16 = (GImage)GetChildAt(3);
            m_n17 = (GImage)GetChildAt(4);
            m_list_item = (GList)GetChildComAt(5);
            m_btn_ok = (UI_CommonBtn1Yellow)GetChildComAt(6);
        }
    }
}