/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_ItemSlotSkin : GComponent
    {
        public UI_IItemSlotSkin m_item;
        public GLoader m_img_element;
        public GList m_list_star;
        public GTextField m_txt_count;
        public const string URL = "ui://0qeyzr63pcjuq";

        public static UI_ItemSlotSkin CreateInstance()
        {
            return (UI_ItemSlotSkin)UIPackage.CreateComponet("CommonComponents", "ItemSlotSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_item = (UI_IItemSlotSkin)GetChildComAt(0);
            m_img_element = (GLoader)GetChildAt(1);
            m_list_star = (GList)GetChildComAt(2);
            m_txt_count = (GTextField)GetChildAt(3);
        }
    }
}