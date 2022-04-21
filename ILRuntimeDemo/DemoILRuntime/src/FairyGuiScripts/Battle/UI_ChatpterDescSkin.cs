/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_ChatpterDescSkin : GComponent
    {
        public GTextField m_tf_desc;
        public const string URL = "ui://ej3y9mmylwv5b1";

        public static UI_ChatpterDescSkin CreateInstance()
        {
            return (UI_ChatpterDescSkin)UIPackage.CreateComponet("Battle", "ChatpterDescSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_tf_desc = (GTextField)GetChildAt(0);
        }
    }
}