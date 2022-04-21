/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Ship
{
    public partial class UI_ShipPartItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_n8;
        public GImage m_n7;
        public GLoader m_img_icon;
        public GImage m_img_lock;
        public GImage m_img_complete;
        public GImage m_img_unlock;
        public const string URL = "ui://6uax1a6mdibi5";

        public static UI_ShipPartItemSkin CreateInstance()
        {
            return (UI_ShipPartItemSkin)UIPackage.CreateComponet("Ship", "ShipPartItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_n8 = (GImage)GetChildAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_img_lock = (GImage)GetChildAt(3);
            m_img_complete = (GImage)GetChildAt(4);
            m_img_unlock = (GImage)GetChildAt(5);
        }
    }
}