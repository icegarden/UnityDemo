/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Bag
{
    public partial class UI_FriendListItemSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_img_arrow;
        public GTextField m_txt_groupName;
        public GList m_list_item;
        public GButton m_btn_group;
        public const string URL = "ui://e98lwrlol1me2x";

        public static UI_FriendListItemSkin CreateInstance()
        {
            return (UI_FriendListItemSkin)UIPackage.CreateComponet("Bag", "FriendListItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_img_arrow = (GImage)GetChildAt(1);
            m_txt_groupName = (GTextField)GetChildAt(2);
            m_list_item = (GList)GetChildComAt(3);
            m_btn_group = (GButton)GetChildComAt(4);
        }
    }
}