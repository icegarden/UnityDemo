/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignConditionItemSkin : GComponent
    {
        public GImage m_n1;
        public GImage m_img_star;
        public GLoader m_img_icon;
        public GTextField m_txt_count;
        public GTextField m_txt_elevel;
        public GTextField m_txt_wlevel;
        public GImage m_img_selected;
        public const string URL = "ui://e8jsnjd3ho4vy";

        public static UI_AssignConditionItemSkin CreateInstance()
        {
            return (UI_AssignConditionItemSkin)UIPackage.CreateComponet("Assign", "AssignConditionItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n1 = (GImage)GetChildAt(0);
            m_img_star = (GImage)GetChildAt(1);
            m_img_icon = (GLoader)GetChildAt(2);
            m_txt_count = (GTextField)GetChildAt(3);
            m_txt_elevel = (GTextField)GetChildAt(4);
            m_txt_wlevel = (GTextField)GetChildAt(5);
            m_img_selected = (GImage)GetChildAt(6);
        }
    }
}