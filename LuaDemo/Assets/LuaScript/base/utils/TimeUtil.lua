TimeUtil = {}
local function onBeat()
    local list = TimeUtil.__list;
    for _, v in ilist(list) do
        local func = v.__tickDelegate;
        func(v);
    end
    local framelist = TimeUtil.__frameListener;
    for _, v in ilist(framelist) do
        v.func(v.callThis);
    end
end
function TimeUtil.init()
    TimeUtil.__list = list:new();
    TimeUtil.__frameListener = list:new();
    UpdateBeat:Add(onBeat);
    local timer = GameTimer:new();
end
-- 每帧都会触发的函数
function TimeUtil.addFrameListener(func, callThis)
    callThis = callThis or nil;
    local o = {};
    o.func = func;
    o.callThis = callThis;
    TimeUtil.__frameListener:push(o);
end
function TimeUtil.removeFrameListener(func, callThis)
    callThis = callThis or nil;
    local framelist = TimeUtil.__frameListener;
    for k, v in ilist(framelist) do
        local vfunc = v.func;
        local vcallThis = v.callThis;
        if (vfunc == func and vcallThis == callThis) then
            framelist:remove(k)
            return;
        end
    end
end
return TimeUtil
