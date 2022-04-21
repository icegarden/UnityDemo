ModuleManager = {}
function ModuleManager.ins()
    if (ModuleManager.__ins == nil) then
        ModuleManager.__ins = ModuleManager:new();
    end
    return ModuleManager.__ins;
end

function ModuleManager:new()
    if (ModuleManager.__ins ~= nil) then
        return ModuleManager.__ins
    end
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    o.mediatorDic = {};
    o.clsDic = {};

    return o;
end

function ModuleManager:openModule(id)
    local clsDic = self.clsDic;
    local mediatorDic = self.mediatorDic;
    local med = mediatorDic[id];
    if (med == nil) then
        local cls = clsDic[id];
        if (cls ~= nil) then
            med = cls:new();
            mediatorDic[id] = med;
            med.moduleId = id;
            med:createView();
            med:onInit();
        end
    end
    med:show()
end

function ModuleManager:closeModule(id)
    local dic = self.mediatorDic;
    local med = dic[id];
    if (med ~= nil) then
        med:hide();
    end
end
return ModuleManager
