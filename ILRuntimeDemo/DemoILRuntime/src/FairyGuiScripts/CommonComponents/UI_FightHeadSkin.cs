/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_FightHeadSkin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_head;
        public GLoader m_img_slot;
        public GLoader m_img_type;
        public GTextField m_txt_level;
        public GTextField m_txt_elevel;
        public const string URL = "ui://0qeyzr63sig26c";

        public static UI_FightHeadSkin CreateInstance()
        {
            return (UI_FightHeadSkin)UIPackage.CreateComponet("CommonComponents", "FightHeadSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_head = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
            m_img_type = (GLoader)GetChildAt(3);
            m_txt_level = (GTextField)GetChildAt(4);
            m_txt_elevel = (GTextField)GetChildAt(5);
        }
    }
}