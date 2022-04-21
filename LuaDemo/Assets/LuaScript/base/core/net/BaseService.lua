local pb = require("pb");
local Application = UnityEngine.Application;
BaseService = {}
function BaseService:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    return o;
end

function BaseService:onRegist()

end

function BaseService:loadPb(fileName)
    local prePath = Application.dataPath .. "/ProtobufTopb/pbfiles/"
    assert(pb.loadfile(prePath .. fileName .. ".pb"));
end

function BaseService:registHandler(cmd, func, protoName)
    local dic = NetService.cmdHandlerDic;
    local tmp = dic[cmd];
    if (tmp ~= nil) then
        Debug.log("已为cmd:" .. cmd .. "注册回调，请勿重复注册");
        return;
    end
    local obj = {};
    obj.func = func;
    obj.callThis = self;
    obj.protoName = protoName;
    dic[cmd] = obj;
end

function BaseService:sendData(cmd, data, protoName)
    NetService.sendData(cmd, data, protoName);
end
return BaseService;
