/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_BagSlotSkin : GButton
    {
        public Controller m_state;
        public GComponent m_item;
        public GImage m_n7;
        public GImage m_btn_select;
        public const string URL = "ui://e98lwrlopcjut";

        public static UI_BagSlotSkin CreateInstance()
        {
            return (UI_BagSlotSkin)UIPackage.CreateComponet("Bag", "BagSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_item = (GComponent)GetChildComAt(0);
            m_n7 = (GImage)GetChildAt(1);
            m_btn_select = (GImage)GetChildAt(2);
        }
    }
}