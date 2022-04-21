/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Halidom
{
    public partial class UI_HalidomChipItemSkin : GComponent
    {
        public GComponent m_item;
        public GLoader m_img_tab;
        public GProgressBar m_pb_count;
        public const string URL = "ui://rqnkl6749hyns";

        public static UI_HalidomChipItemSkin CreateInstance()
        {
            return (UI_HalidomChipItemSkin)UIPackage.CreateComponet("Halidom", "HalidomChipItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (GComponent)GetChildComAt(0);
            m_img_tab = (GLoader)GetChildAt(1);
            m_pb_count = (GProgressBar)GetChildComAt(2);
        }
    }
}