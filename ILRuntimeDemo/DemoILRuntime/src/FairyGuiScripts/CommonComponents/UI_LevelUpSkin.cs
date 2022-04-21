/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_LevelUpSkin : GComponent
    {
        public GImage m_n0;
        public GImage m_n3;
        public GImage m_n1;
        public GList m_list_item;
        public GTextField m_tf_lv1;
        public GTextField m_tf_lv2;
        public const string URL = "ui://0qeyzr63ez5u6l";

        public static UI_LevelUpSkin CreateInstance()
        {
            return (UI_LevelUpSkin)UIPackage.CreateComponet("CommonComponents", "LevelUpSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_n3 = (GImage)GetChildAt(1);
            m_n1 = (GImage)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_tf_lv1 = (GTextField)GetChildAt(4);
            m_tf_lv2 = (GTextField)GetChildAt(5);
        }
    }
}