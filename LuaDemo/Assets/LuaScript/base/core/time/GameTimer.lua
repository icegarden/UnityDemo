GameTimer = {}
local function onTick(timer)
    
end
function GameTimer:new()
    local o = {}
    setmetatable(o, self)
    -- 私有
    o.__tickDelegate = onTick;
    -- 运行时间
    o.runTime = 0;
    o.__scale = 1;
    o.__paused = true;
    o.__stoped = true;
    TimeUtil.__list:push(o);
    return o;
end

function GameTimer:pause()
    self.__paused = true;
end

function GameTimer:resume()
    self.__paused = false;
end

function GameTimer:start()
    self.__paused = false;
    self.__stoped = false;
end

function GameTimer:stop()
    self.__stoped = true;
end

function GameTimer:scale(val)
    self.__scale = val;
end
-- func:回调函数
-- delay 间隔多长时间执行一次，为0表示每帧都执行
-- count 表示执行几次，为0表示无限执行
function GameTimer:addListener(func, callThis, delay, count)

end
return GameTimer;
