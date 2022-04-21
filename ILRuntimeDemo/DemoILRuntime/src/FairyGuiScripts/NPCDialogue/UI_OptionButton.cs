/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace NPCDialogue
{
    public partial class UI_OptionButton : GComponent
    {
        public GImage m_n0;
        public GRichTextField m_title;
        public const string URL = "ui://0dkdlrs3j3ji9";

        public static UI_OptionButton CreateInstance()
        {
            return (UI_OptionButton)UIPackage.CreateComponet("NPCDialogue", "OptionButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_n0 = (GImage)GetChildAt(0);
            m_title = (GRichTextField)GetChildAt(1);
        }
    }
}