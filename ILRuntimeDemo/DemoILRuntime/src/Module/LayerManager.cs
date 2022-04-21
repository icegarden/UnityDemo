using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
namespace DemoILRuntime
{
    public class LayerManager
    {
        private static Dictionary<LayerId, GComponent> containerDic;
        public static void Init()
        {
            containerDic = new Dictionary<LayerId, GComponent>();
            var mapcontainer = createContainer("mapcontainer");
            var mapbackground = createContainer("mapbackground");
            var mapmiddle = createContainer("mapmiddle");
            var maptop = createContainer("maptop");
            var maprole = createContainer("maprole");
            var uicontainer = createContainer("uicontainer");
            var battleEffect = createContainer("battleEffect");
            var uibottom = createContainer("uibottom");
            var uibottommenu = createContainer("uibottommenu");
            var uimiddle = createContainer("uimiddle");
            var uitopmenu = createContainer("uitopmenu");
            var uiupmenu = createContainer("uiupmenu");
            var dialog = createContainer("dialog");
            var fightLayer = createContainer("fightLayer");
            var chatentry = createContainer("chatentry");
            var chatcon = createContainer("chatcon");
            var alert = createContainer("alert");
            var untouch = createContainer("untouch");
            var message = createContainer("message");

            GRoot.inst.AddChild(mapcontainer);
            GRoot.inst.AddChild(uicontainer);

            mapcontainer.AddChild(mapbackground);
            mapcontainer.AddChild(mapmiddle);
            mapcontainer.AddChild(maptop);
            mapcontainer.AddChild(maprole);

            uicontainer.AddChild(battleEffect);
            uicontainer.AddChild(uibottom);
            uicontainer.AddChild(uibottommenu);
            uicontainer.AddChild(uimiddle);
            uicontainer.AddChild(uitopmenu);
            uicontainer.AddChild(uiupmenu);
            uicontainer.AddChild(fightLayer);
            uicontainer.AddChild(chatentry);
            uicontainer.AddChild(chatcon);
            uicontainer.AddChild(dialog);
            uicontainer.AddChild(alert);
            uicontainer.AddChild(untouch);
            uicontainer.AddChild(message);



            containerDic.Add(LayerId.MAP_CONTAINER, mapcontainer);
            containerDic.Add(LayerId.MAP_BACKGROUD, mapbackground);
            containerDic.Add(LayerId.MAP_MIDDLE, mapmiddle);
            containerDic.Add(LayerId.MAP_TOP, maptop);
            containerDic.Add(LayerId.MAP_ROLE, maprole);
            containerDic.Add(LayerId.UI_CONTAINER, uicontainer);
            containerDic.Add(LayerId.UI_BATTLE_EFFECT, battleEffect);
            containerDic.Add(LayerId.UI_BOTTOM, uibottom);
            containerDic.Add(LayerId.UI_BOTTOMMENU, uibottommenu);
            containerDic.Add(LayerId.UI_UP_BOTTOMMEMU, uimiddle);
            containerDic.Add(LayerId.UI_TOPMENU, uitopmenu);
            containerDic.Add(LayerId.UI_UP_MENU, uiupmenu);
            containerDic.Add(LayerId.FIGHTLAYER, fightLayer);
            containerDic.Add(LayerId.CHAT_ENTRY, chatentry);
            containerDic.Add(LayerId.CHAT, chatcon);
            containerDic.Add(LayerId.DIALOG, dialog);
            containerDic.Add(LayerId.ALERT, alert);
            containerDic.Add(LayerId.UNTOUCH, untouch);
            containerDic.Add(LayerId.MESSAGE, message);

            Stage.inst.ResetInputState();
        }

        private static GComponent createContainer(string name)
        {
            var obj = new GComponent();
            obj.gameObjectName = name;
            return obj;
        }

        public static void addChild(GObject child, LayerId id)
        {
            GComponent layer;
            containerDic.TryGetValue(id, out layer);
            if (layer != null && child != null)
            {
                layer.AddChild(child);
            }
        }

        public static void removeChild(GComponent child)
        {
            child.RemoveFromParent();
        }

        public static GComponent getLayer(LayerId id)
        {
            GComponent layer;
            containerDic.TryGetValue(id, out layer);
            return layer;
        }
    }
}
