/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_GuanKaPlayerSkin : GComponent
    {
        public GLoader m_img_bg;
        public GTextField m_tf_title;
        public GList m_list_player;
        public GButton m_btn_chx;
        public const string URL = "ui://ej3y9mmylwv5b3";

        public static UI_GuanKaPlayerSkin CreateInstance()
        {
            return (UI_GuanKaPlayerSkin)UIPackage.CreateComponet("Battle", "GuanKaPlayerSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_tf_title = (GTextField)GetChildAt(1);
            m_list_player = (GList)GetChildComAt(2);
            m_btn_chx = (GButton)GetChildComAt(3);
        }
    }
}