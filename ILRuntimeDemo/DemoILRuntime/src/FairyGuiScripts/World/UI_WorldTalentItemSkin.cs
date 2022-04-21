/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace World
{
    public partial class UI_WorldTalentItemSkin : GComponent
    {
        public Controller m_state;
        public GImage m_bg;
        public GLoader m_img_icon;
        public GImage m_n4;
        public const string URL = "ui://63ubk2jomlxa12";

        public static UI_WorldTalentItemSkin CreateInstance()
        {
            return (UI_WorldTalentItemSkin)UIPackage.CreateComponet("World", "WorldTalentItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_state = GetControllerAt(0);
            m_bg = (GImage)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_n4 = (GImage)GetChildAt(2);
        }
    }
}