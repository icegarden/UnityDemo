/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarSignSlotSkin : GButton
    {
        public Controller m_button;
        public Controller m_lock;
        public GImage m_n1;
        public GLoader m_icon;
        public GImage m_n9;
        public GImage m_n7;
        public GImage m_n12;
        public GImage m_n13;
        public GTextField m_txt_level;
        public GTextField m_txt_lock;
        public GTextField m_txt_unlock;
        public const string URL = "ui://xplmw3njho4v15";

        public static UI_StarSignSlotSkin CreateInstance()
        {
            return (UI_StarSignSlotSkin)UIPackage.CreateComponet("StarSign", "StarSignSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_lock = GetControllerAt(1);
            m_n1 = (GImage)GetChildAt(0);
            m_icon = (GLoader)GetChildAt(1);
            m_n9 = (GImage)GetChildAt(2);
            m_n7 = (GImage)GetChildAt(3);
            m_n12 = (GImage)GetChildAt(4);
            m_n13 = (GImage)GetChildAt(5);
            m_txt_level = (GTextField)GetChildAt(6);
            m_txt_lock = (GTextField)GetChildAt(7);
            m_txt_unlock = (GTextField)GetChildAt(8);
        }
    }
}