local EventTrigger = UnityEngine.EventSystems.EventTrigger
local Entry = UnityEngine.EventSystems.EventTrigger.Entry
local TriggerEvent = UnityEngine.EventSystems.EventTrigger.TriggerEvent
local ArrayList = System.Collections.ArrayList
EventUtil = {
    evtDic = {}
}

-- 为obj添加鼠标交互事件
function EventUtil.addListener(obj, type, listenerFunc, callthis)
    local function callBackFunc(e)
        if (callthis == nil) then
            listenerFunc(e)
        else
            listenerFunc(callthis, e)
        end
    end
    local trigger = obj:GetComponent(typeof(EventTrigger))
    if (trigger == nil) then
        trigger = obj:AddComponent(typeof(EventTrigger))
    end
    local evt = Entry.New()
    evt.eventID = type
    evt.callback = TriggerEvent.New()
    evt.callback:AddListener(callBackFunc)
    trigger.triggers:Add(evt);
    local tmp = {};
    tmp.type = type;
    tmp.obj = obj;
    tmp.func = listenerFunc;
    tmp.callthis = callthis;
    tmp.evt = evt;
    local arr = EventUtil.evtDic[type];
    if (arr == nil) then
        arr = ArrayList.New();
        EventUtil.evtDic[type] = arr;
    end
    arr:Add(tmp);
end

function EventUtil.removeListener(obj, type, listenerFunc, callthis)
    local trigger = obj:GetComponent(typeof(EventTrigger))
    if (trigger == nil) then
        return;
    end
    local arr = EventUtil.evtDic[type];
    if (arr == nil) then
        return;
    end
    local len = arr.Count;
    if (len > 0) then
        len = len - 1;
        for i = 0, len, 1 do
            local v = arr[i];
            if (v ~= nil) then
                if (v.obj == obj and v.type == type and v.func == listenerFunc and v.callthis == callthis) then
                    trigger.triggers:Remove(v.evt);
                    arr:RemoveAt(i);
                    break
                end
            end
        end
    end
end

return EventUtil
