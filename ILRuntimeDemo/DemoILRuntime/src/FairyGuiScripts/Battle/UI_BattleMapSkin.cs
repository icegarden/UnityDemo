/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleMapSkin : GComponent
    {
        public UI_BattleMapContent m_content;
        public GLoader m_img_bottom;
        public GButton m_btn_close;
        public GGroup m_group_bottom;
        public GLoader m_img_top;
        public GImage m_n4;
        public GTextField m_title;
        public GGroup m_group_top;
        public const string URL = "ui://ej3y9mmylwv5as";

        public static UI_BattleMapSkin CreateInstance()
        {
            return (UI_BattleMapSkin)UIPackage.CreateComponet("Battle", "BattleMapSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_content = (UI_BattleMapContent)GetChildComAt(0);
            m_img_bottom = (GLoader)GetChildAt(1);
            m_btn_close = (GButton)GetChildComAt(2);
            m_group_bottom = (GGroup)GetChildAt(3);
            m_img_top = (GLoader)GetChildAt(4);
            m_n4 = (GImage)GetChildAt(5);
            m_title = (GTextField)GetChildAt(6);
            m_group_top = (GGroup)GetChildAt(7);
        }
    }
}