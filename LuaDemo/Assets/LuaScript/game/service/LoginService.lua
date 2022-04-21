LoginService = BaseService:new();
function LoginService:new()
    local o = BaseService:new();
    setmetatable(o, self);
    self.__index = self;
    return o;
end

local function onGetUser_S(ser, msg)
    Debug.log(msg);
end

function LoginService:onRegist()
    self:loadPb("Login");
    self:registHandler(Cmd.GetUser_S, onGetUser_S, "GetUser_S");
end

function LoginService:getUserInfo(info)
    self:sendData(Cmd.GetUser_C, info, "GetUser_C");
end
return LoginService;
