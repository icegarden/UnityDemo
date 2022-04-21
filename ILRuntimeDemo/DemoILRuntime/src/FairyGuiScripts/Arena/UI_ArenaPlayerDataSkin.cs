/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Arena
{
    public partial class UI_ArenaPlayerDataSkin : GComponent
    {
        public Controller m_result;
        public GImage m_n51;
        public GImage m_n54;
        public GGraph m_n37;
        public GGraph m_n41;
        public GGraph m_n42;
        public GGraph m_n43;
        public GList m_list_item;
        public GImage m_n49;
        public GImage m_n50;
        public GImage m_n47;
        public GImage m_n48;
        public GTextField m_txt_name;
        public GTextField m_txt_tip2;
        public GTextField m_txt_tip3;
        public GTextField m_txt_tip4;
        public const string URL = "ui://m8qegzmncnj3d";

        public static UI_ArenaPlayerDataSkin CreateInstance()
        {
            return (UI_ArenaPlayerDataSkin)UIPackage.CreateComponet("Arena", "ArenaPlayerDataSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_result = GetControllerAt(0);
            m_n51 = (GImage)GetChildAt(0);
            m_n54 = (GImage)GetChildAt(1);
            m_n37 = (GGraph)GetChildAt(2);
            m_n41 = (GGraph)GetChildAt(3);
            m_n42 = (GGraph)GetChildAt(4);
            m_n43 = (GGraph)GetChildAt(5);
            m_list_item = (GList)GetChildComAt(6);
            m_n49 = (GImage)GetChildAt(7);
            m_n50 = (GImage)GetChildAt(8);
            m_n47 = (GImage)GetChildAt(9);
            m_n48 = (GImage)GetChildAt(10);
            m_txt_name = (GTextField)GetChildAt(11);
            m_txt_tip2 = (GTextField)GetChildAt(12);
            m_txt_tip3 = (GTextField)GetChildAt(13);
            m_txt_tip4 = (GTextField)GetChildAt(14);
        }
    }
}