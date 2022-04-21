/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace CommonComponents
{
    public partial class UI_PlayerHead2Skin : GComponent
    {
        public GLoader m_img_bg;
        public GLoader m_img_icon;
        public GLoader m_img_slot;
        public const string URL = "ui://0qeyzr63h7466i";

        public static UI_PlayerHead2Skin CreateInstance()
        {
            return (UI_PlayerHead2Skin)UIPackage.CreateComponet("CommonComponents", "PlayerHead2Skin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_bg = (GLoader)GetChildAt(0);
            m_img_icon = (GLoader)GetChildAt(1);
            m_img_slot = (GLoader)GetChildAt(2);
        }
    }
}