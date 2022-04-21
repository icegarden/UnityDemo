local SocketClient = SocketClient;
local pb = require("pb");
NetService = {}
NetService.serviceDic = {};
NetService.cmdHandlerDic = {};
local function onConnect()
    Debug.log("socket连接成功")
    NetService.isConnected = true;
    dispatch(EventType.SocketConnect);
end

local function onMessage(cmd, data)
    local dic = NetService.cmdHandlerDic;
    local obj = dic[cmd];
    if (obj == nil) then
        Debug.log("未注册cmd:" .. cmd .. "的回调");
        return;
    end
    local func = obj.func;
    local callThis = obj.callThis;
    local protoName = obj.protoName;
    local val = tolua.tolstring(data)
    local msg = assert(pb.decode(protoName, val))
    if (callThis == nil) then
        func(msg);
    else
        func(callThis, msg);
    end
end

local function onDisconnect()
    NetService.isConnected = false;
    NetService.client = nil;
    dispatch(EventType.SocketDisConnect);
end
function NetService.connect(host)
    if (NetService.isConnected == true) then
        return;
    end
    local client = SocketClient.New();
    NetService.client = client;
    client.onData = onMessage;
    client.onConnect = onConnect;
    client.onDisconnect = onDisconnect;
    client:createSocket(host);
end

function NetService.sendData(cmd, data, protoName)
    local client = NetService.client;
    if (client == nil) then
        return
    end
    local info = assert(pb.encode(protoName, data))
    client:SendData(cmd, info);
end

function NetService.getService(cls)
    local clsname = cls.__className;
    return NetService.serviceDic[clsname];
end
return NetService;
