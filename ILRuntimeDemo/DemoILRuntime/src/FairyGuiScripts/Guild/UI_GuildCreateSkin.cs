/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Guild
{
    public partial class UI_GuildCreateSkin : GComponent
    {
        public GLabel m_bg;
        public GImage m_n6;
        public UI_GuildLogoIconSkin m_comp_logo;
        public GComponent m_item_cost;
        public GTextField m_txt_cost;
        public GTextInput m_txt_name;
        public GButton m_btn_confirm;
        public GButton m_btn_cancel;
        public GButton m_btn_change;
        public GGroup m_n11;
        public const string URL = "ui://tae9x4e9yfna0";

        public static UI_GuildCreateSkin CreateInstance()
        {
            return (UI_GuildCreateSkin)UIPackage.CreateComponet("Guild", "GuildCreateSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLabel)GetChildComAt(0);
            m_n6 = (GImage)GetChildAt(1);
            m_comp_logo = (UI_GuildLogoIconSkin)GetChildComAt(2);
            m_item_cost = (GComponent)GetChildComAt(3);
            m_txt_cost = (GTextField)GetChildAt(4);
            m_txt_name = (GTextInput)GetChildAt(5);
            m_btn_confirm = (GButton)GetChildComAt(6);
            m_btn_cancel = (GButton)GetChildComAt(7);
            m_btn_change = (GButton)GetChildComAt(8);
            m_n11 = (GGroup)GetChildAt(9);
        }
    }
}