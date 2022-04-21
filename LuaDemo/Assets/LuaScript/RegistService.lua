RegistService = {}
local function regist(cls, clsName)
    cls.__className = clsName;
    local dic = NetService.serviceDic;
    local ins = cls:new();
    dic[clsName] = ins;
    ins:onRegist();
end

function getService(cls)
    return NetService.getService(cls);
end
function RegistService.regist()
    regist(LoginService, "LoginService");
end
return RegistService;
