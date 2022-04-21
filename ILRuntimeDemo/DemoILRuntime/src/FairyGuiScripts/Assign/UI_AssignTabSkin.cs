/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Assign
{
    public partial class UI_AssignTabSkin : GButton
    {
        public Controller m_button;
        public Controller m_state;
        public GImage m_n12;
        public GLoader m_img_icon;
        public GProgressBar m_pb_exp;
        public GImage m_n19;
        public GImage m_n13;
        public GImage m_n18;
        public GLoader m_img_level;
        public GRichTextField m_txt_unlock;
        public GRichTextField m_txt_name;
        public const string URL = "ui://e8jsnjd3gikd5";

        public static UI_AssignTabSkin CreateInstance()
        {
            return (UI_AssignTabSkin)UIPackage.CreateComponet("Assign", "AssignTabSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_button = GetControllerAt(0);
            m_state = GetControllerAt(1);
            m_n12 = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_pb_exp = (GProgressBar)GetChildComAt(2);
            m_n19 = (GImage)GetChildAt(3);
            m_n13 = (GImage)GetChildAt(4);
            m_n18 = (GImage)GetChildAt(5);
            m_img_level = (GLoader)GetChildAt(6);
            m_txt_unlock = (GRichTextField)GetChildAt(7);
            m_txt_name = (GRichTextField)GetChildAt(8);
        }
    }
}