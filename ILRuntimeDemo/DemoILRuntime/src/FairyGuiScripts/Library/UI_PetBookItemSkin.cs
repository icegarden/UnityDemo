/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Library
{
    public partial class UI_PetBookItemSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GProgressBar m_pb_exp;
        public const string URL = "ui://vkxqgoc5ycl73";

        public static UI_PetBookItemSkin CreateInstance()
        {
            return (UI_PetBookItemSkin)UIPackage.CreateComponet("Library", "PetBookItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_pb_exp = (GProgressBar)GetChildComAt(3);
        }
    }
}