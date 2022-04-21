/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_IItemSlotSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GImage m_img_chip;
        public const string URL = "ui://0qeyzr63pcjup";

        public static UI_IItemSlotSkin CreateInstance()
        {
            return (UI_IItemSlotSkin)UIPackage.CreateComponet("CommonComponents", "IItemSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_chip = (GImage)GetChildAt(3);
        }
    }
}