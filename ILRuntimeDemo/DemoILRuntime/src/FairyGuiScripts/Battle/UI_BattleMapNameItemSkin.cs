/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Battle
{
    public partial class UI_BattleMapNameItemSkin : GComponent
    {
        public GList m_list_head;
        public GImage m_icon_lock;
        public GImage m_icon_normal;
        public GImage m_icon_fight;
        public GImage m_n0;
        public GTextField m_tf_name;
        public GGroup m_group_content;
        public const string URL = "ui://ej3y9mmylwv5au";

        public static UI_BattleMapNameItemSkin CreateInstance()
        {
            return (UI_BattleMapNameItemSkin)UIPackage.CreateComponet("Battle", "BattleMapNameItemSkin");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_list_head = (GList)GetChildComAt(0);
            m_icon_lock = (GImage)GetChildAt(1);
            m_icon_normal = (GImage)GetChildAt(2);
            m_icon_fight = (GImage)GetChildAt(3);
            m_n0 = (GImage)GetChildAt(4);
            m_tf_name = (GTextField)GetChildAt(5);
            m_group_content = (GGroup)GetChildAt(6);
        }
    }
}