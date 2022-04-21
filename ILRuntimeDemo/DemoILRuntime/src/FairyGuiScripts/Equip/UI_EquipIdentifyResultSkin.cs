/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Equip
{
    public partial class UI_EquipIdentifyResultSkin : GComponent
    {
        public GLoader m_img_icon;
        public GLabel m_title;
        public GComponent m_list_item;
        public const string URL = "ui://5ch1xwvwl1me3e";

        public static UI_EquipIdentifyResultSkin CreateInstance()
        {
            return (UI_EquipIdentifyResultSkin)UIPackage.CreateComponet("Equip", "EquipIdentifyResultSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_icon = (GLoader)GetChildAt(0);
            m_title = (GLabel)GetChildComAt(1);
            m_list_item = (GComponent)GetChildComAt(2);
        }
    }
}