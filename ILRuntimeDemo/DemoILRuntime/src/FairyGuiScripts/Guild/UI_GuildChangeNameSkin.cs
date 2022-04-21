/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildChangeNameSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n2;
        public GComponent m_item_cost;
        public GTextField m_txt_cost;
        public GTextInput m_txt_name;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GGroup m_n8;
        public const string URL = "ui://tae9x4e9yfnag";

        public static UI_GuildChangeNameSkin CreateInstance()
        {
            return (UI_GuildChangeNameSkin)UIPackage.CreateComponet("Guild", "GuildChangeNameSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n2 = (GImage)GetChildAt(1);
            m_item_cost = (GComponent)GetChildComAt(2);
            m_txt_cost = (GTextField)GetChildAt(3);
            m_txt_name = (GTextInput)GetChildAt(4);
            m_btn_confirm = (GButton)GetChildComAt(5);
            m_btn_cancel = (GButton)GetChildComAt(6);
            m_n8 = (GGroup)GetChildAt(7);
        }
    }
}