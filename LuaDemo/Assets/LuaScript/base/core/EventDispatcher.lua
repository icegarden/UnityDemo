local ArrayList = System.Collections.ArrayList
EventDispatcher = {}
function EventDispatcher:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    o.evtDic = {};
    return o;
end

function EventDispatcher:on(type, callFunc, callThis, ...)
    local dic = self.evtDic;
    local arr = dic[type];
    local args = {...};
    local isonce = args[1] or false;
    if (arr == nil) then
        arr = ArrayList.New();
        dic[type] = arr;
    end

    local has = false;
    local len = arr.Count;
    if (len > 0) then
        len = len - 1;
        for i = 0, len, 1 do
            local v = arr[i];
            if (v ~= nil) then
                local func = v.func;
                local callthis = v.callthis;
                if (func == callFunc and callThis == callthis) then
                    has = true;
                    break
                end
            end
        end
    end

    if (has == false) then
        local obj = {};
        obj.func = callFunc;
        obj.callthis = callThis;
        obj.once = isonce;
        arr:Add(obj);
    end
end

function EventDispatcher:off(type, callFunc, callThis)
    local dic = self.evtDic;
    local arr = dic[type];
    if (arr ~= nil) then
        local len = arr.Count;
        if (len > 0) then
            len = len - 1;
            for i = 0, len, 1 do
                local v = arr[i];
                if (v ~= nil) then
                    local func = v.func;
                    local callthis = v.callthis;
                    if (func == callFunc and callThis == callthis) then
                        arr:RemoveAt(i);
                        break
                    end
                end
            end
        end
    end
end

function EventDispatcher:offAll()
    local dic = self.evtDic;
    for k, v in pairs(dic) do
        local arr = v;
        local len = arr.Count;
        if (len > 0) then
            len = len - 1;
            for i = 0, len, 1 do
                local item = arr[i];
                item.func = nil;
                item.callthis = nil;
            end
        end
        arr:Clear();
        dic[k] = nil;
    end
    self.evtDic = {};
end
function EventDispatcher:once(type, callFunc, callThis)
    self:on(type, callFunc, callThis, true);
end
function EventDispatcher:dispatch(type, ...)
    local dic = self.evtDic;
    local arr = dic[type];
    local args = {...};
    local cache = {};
    local removeInx = 1;
    if (arr ~= nil) then
        local len = arr.Count;
        if (len > 0) then
            len = len - 1;
            for i = 0, len, 1 do
                local v = arr[i];
                if (v ~= nil) then
                    local func = v.func;
                    local callthis = v.callthis;
                    local once = v.once;
                    if (func ~= nil) then
                        if (callthis ~= nil) then
                            func(callthis, args)
                        else
                            func(args)
                        end
                    end

                    if (once == true) then
                        cache[removeInx] = v;
                        removeInx = removeInx + 1;
                    end
                end
            end
        end
    end
    -- lua的for循环没法动态的去更改indx的终值
    -- 所以采用这种方式
    if (removeInx > 1) then
        for k, v in pairs(cache) do
            arr:Remove(v);
        end
    end
end

local ed = EventDispatcher:new();
function on(type, callFunc, callThis, ...)
    local args = {...};
    ed:on(type, callFunc, callThis, args);
end
function off(type, callFunc, callThis)
    ed:off(type, callFunc, callThis);
end
function once(type, callFunc, callThis)
    ed:once(type, callFunc, callThis);
end
function dispatch(type, ...)
    local args = {...};
    ed:dispatch(type, args);
end
return EventDispatcher
