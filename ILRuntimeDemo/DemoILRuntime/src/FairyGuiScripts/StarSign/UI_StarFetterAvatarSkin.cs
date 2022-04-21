/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace StarSign
{
    public partial class UI_StarFetterAvatarSkin : GComponent
    {
        public Controller m_state;
        public GLoader m_img_avatar;
        public GImage m_img_unlock;
        public GImage m_n6;
        public GImage m_img_lock;
        public GRichTextField m_txt_name;
        public const string URL = "ui://xplmw3njho4vr";

        public static UI_StarFetterAvatarSkin CreateInstance()
        {
            return (UI_StarFetterAvatarSkin)UIPackage.CreateComponet("StarSign", "StarFetterAvatarSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_img_avatar = (GLoader)GetChildAt(0);
            m_img_unlock = (GImage)GetChildAt(1);
            m_n6 = (GImage)GetChildAt(2);
            m_img_lock = (GImage)GetChildAt(3);
            m_txt_name = (GRichTextField)GetChildAt(4);
        }
    }
}