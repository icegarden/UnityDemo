/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Artifact
{
    public partial class UI_TalentUnlockItemSkin : GComponent
    {
        public GLoader m_img_talent;
        public GLoader m_img_bg;
        public GTextField m_txt_level;
        public const string URL = "ui://0uxg7753dibi3b";

        public static UI_TalentUnlockItemSkin CreateInstance()
        {
            return (UI_TalentUnlockItemSkin)UIPackage.CreateComponet("Artifact", "TalentUnlockItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_img_talent = (GLoader)GetChildAt(0);
            m_img_bg = (GLoader)GetChildAt(1);
            m_txt_level = (GTextField)GetChildAt(2);
        }
    }
}