/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerHeadSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public GLoader m_img_type;
        public GTextField m_txt_level;
        public GTextField m_txt_elevel;
        public const string URL = "ui://0qeyzr63l1me29";

        public static UI_PlayerHeadSkin CreateInstance()
        {
            return (UI_PlayerHeadSkin)UIPackage.CreateComponet("CommonComponents", "PlayerHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_type = (GLoader)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_txt_elevel = (GTextField)GetChildAt(5);
        }
    }
}